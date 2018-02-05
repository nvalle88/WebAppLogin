using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authentication.Cookies;
using bd.webappth.servicios.Interfaces;
using bd.webappth.entidades.ViewModels;
using bd.webappth.entidades.Utils;
using bd.webappth.entidades.Negocio;
using System.Linq;
using bd.log.guardar.Servicios;
using bd.log.guardar.ObjectTranfer;
using bd.webappseguridad.entidades.Enumeradores;
using bd.log.guardar.Enumeradores;
using Microsoft.AspNetCore.Authorization;
using bd.webapplogin.entidades.Utils;
using System.Net;

namespace bd.webappth.web.Controllers.MVC
{
   
    public class LoginController : Controller
    {

        private readonly IApiServicio apiServicio;


        public LoginController(IApiServicio apiServicio)
        {
            this.apiServicio = apiServicio;

        }

        private void InicializarMensaje(string mensaje)
        {
            if (mensaje == null)
            {
                mensaje = "";
            }
            ViewData["Error"] = mensaje;
        }


        public IActionResult Index(string mensaje, string returnUrl=null)
        {
            
            InicializarMensaje(mensaje);
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }


        private async void UsuarioBloqueado(Response response,Login login)
        {
            if (!string.IsNullOrEmpty(response.Resultado.ToString()))
            {

                var estaBloquado = JsonConvert.DeserializeObject<UsuarioBloqueado>(response.Resultado.ToString());
                if (estaBloquado.EstaBloqueado)
                {
                    var responseLog = new EntradaLog
                    {
                        ExceptionTrace = null,
                        LogCategoryParametre = Convert.ToString(LogCategoryParameter.Permission),
                        LogLevelShortName = Convert.ToString(LogLevelParameter.ADV),
                        ObjectPrevious = null,
                        ObjectNext = null,
                    };
                    
                    await apiServicio.SalvarLog<entidades.Utils.Response>("/Login/UsuarioBloqueado", HttpContext, responseLog,login);

                };
            };
        }
            /// <summary>
            /// Autentica al usuario y crea el token en la base de datos
            /// autentica el usuario en la cookie basado basado en los Claims 
            /// </summary>
            /// <param name="login"></param>
            /// <param name="returnUrl"></param>
            /// <returns></returns>
            public async Task<IActionResult> Login(Login login,string returnUrl=null)
        {

            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(LoginController.Index));
            }        

           var response = await apiServicio.ObtenerElementoAsync1<Response>(login,
                                                             new Uri(WebApp.BaseAddressSeguridad),
                                                             "api/Adscpassws/Login");

            UsuarioBloqueado(response,login);
            
            if (!response.IsSuccess)
            {
                return RedirectToAction(nameof(LoginController.Index), new { mensaje = response.Message });
            }

           // var usuario = JsonConvert.DeserializeObject<Adscpassw>(response.Resultado.ToString());

            var codificar = new Codificar
            {
                Entrada= Convert.ToString(DateTime.Now),
            };

            Guid guidUsuario;
            guidUsuario = Guid.NewGuid();

            var permisoUsuario = new PermisoUsuario
            {
                Usuario=login.Usuario,
                Token= Convert.ToString(guidUsuario),
            };

            var salvarToken = await apiServicio.InsertarAsync<Response>(permisoUsuario,new Uri(WebApp.BaseAddressSeguridad), "api/Adscpassws/SalvarToken");


            var claims = new[]
            {
                new Claim(ClaimTypes.Name,login.Usuario),
                new Claim(ClaimTypes.SerialNumber,Convert.ToString(guidUsuario))
               
            };

            var principal = new ClaimsPrincipal(new ClaimsIdentity(claims,"Cookies"));

           await HttpContext.Authentication.SignInAsync("Cookies", principal, new Microsoft.AspNetCore.Http.Authentication.AuthenticationProperties { IsPersistent = true });

            if (string.IsNullOrEmpty(returnUrl))
            {
                return RedirectToActionPermanent(nameof(HomesController.Menu), "Homes");
            }

            return LocalRedirect(returnUrl);

        }
        /// <summary>
        /// Elimina el Token de la base de datos y desautentica al usuario de la Cookie
        /// </summary>
        /// <returns></returns>
        [Authorize(Policy = PoliticaSeguridad.TienePermiso)]
        public async Task<IActionResult> Salir()
        {
            try
            {
                var claim = HttpContext.User.Identities.Where(x => x.NameClaimType == ClaimTypes.Name).FirstOrDefault();
                var token = claim.Claims.Where(c => c.Type == ClaimTypes.SerialNumber).FirstOrDefault().Value;
                var NombreUsuario = claim.Claims.Where(c => c.Type == ClaimTypes.Name).FirstOrDefault().Value;

                var adscpasswSend = new Adscpassw
                {
                    AdpsLoginAdm = NombreUsuario,
                    AdpsToken = token
                };

                Adscpassw adscpassw = new Adscpassw();
                adscpassw = await GetAdscPassws(adscpasswSend);
                var response = await EliminarToken(adscpassw);
                if (response.IsSuccess)
                {
                    await HttpContext.Authentication.SignOutAsync("Cookies");
                    return RedirectToAction(nameof(LoginController.Index), "Login");
                }
                return RedirectToAction(nameof(HomesController.Menu), "Homes");
            }
            catch (Exception)
            {
                await HttpContext.Authentication.SignOutAsync("Cookies");
                return RedirectToAction(nameof(LoginController.Index), "Login");
            }

        }

        private async Task<Adscpassw> GetAdscPassws(Adscpassw adscpassw)
        {
            try
            {
                if (!adscpassw.Equals(null))
                {
                    var respuesta = await apiServicio.ObtenerElementoAsync1<Response>(adscpassw, new Uri(WebApp.BaseAddressSeguridad),
                                                                  "api/Adscpassws/SeleccionarMiembroLogueado");

                    if (respuesta.IsSuccess)
                    {
                        var obje = JsonConvert.DeserializeObject<Adscpassw>(respuesta.Resultado.ToString());
                        return obje;
                    }

                }

                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private async Task<Response> EliminarToken(Adscpassw adscpassw)
        {
            Response response = new Response();
            try
            {
                if (!string.IsNullOrEmpty(adscpassw.AdpsLogin))
                {
                    response = await apiServicio.EditarAsync<Response>(adscpassw, new Uri(WebApp.BaseAddressSeguridad),
                                                                 "api/Adscpassws/EliminarToken");

                    if (response.IsSuccess)
                    {
                        await GuardarLogService.SaveLogEntry(new LogEntryTranfer
                        {
                            ApplicationName = Convert.ToString(Aplicacion.WebAppTh),
                            EntityID = string.Format("{0} : {1}", "Sistema", adscpassw.AdpsLogin),
                            LogCategoryParametre = Convert.ToString(LogCategoryParameter.Edit),
                            LogLevelShortName = Convert.ToString(LogLevelParameter.ADV),
                            Message = "Se ha actualizado un estado civil",
                            UserName = "Usuario 1"
                        });

                        return response;
                    }

                }
                return null;
            }
            catch (Exception ex)
            {
                await GuardarLogService.SaveLogEntry(new LogEntryTranfer
                {
                    ApplicationName = Convert.ToString(Aplicacion.WebAppTh),
                    Message = "Editando un estado civil",
                    ExceptionTrace = ex.Message,
                    LogCategoryParametre = Convert.ToString(LogCategoryParameter.Edit),
                    LogLevelShortName = Convert.ToString(LogLevelParameter.ERR),
                    UserName = "Usuario APP webappth"
                });

                return null;
            }
        }


    }
}
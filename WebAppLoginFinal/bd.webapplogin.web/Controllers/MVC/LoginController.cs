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




        public async Task<IActionResult> Login(Login login,string returnUrl=null)
        {

            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(LoginController.Index));
            }        

           var response = await apiServicio.ObtenerElementoAsync1<Response>(login,
                                                             new Uri(WebApp.BaseAddressSeguridad),
                                                             "api/Adscpassws/Login");

           

            if (!response.IsSuccess)
            {
                return RedirectToAction(nameof(LoginController.Index), new { mensaje = response.Message });
            }

            var usuario = JsonConvert.DeserializeObject<Adscpassw>(response.Resultado.ToString());

            var codificar = new Codificar
            {
                Entrada= Convert.ToString(DateTime.Now),
            };

            Guid guidUsuario;
            guidUsuario = Guid.NewGuid();

            var permisoUsuario = new PermisoUsuario
            {
                Usuario=usuario.AdpsLogin,
                Token= Convert.ToString(guidUsuario),
            };

            var salvarToken = await apiServicio.InsertarAsync<Response>(permisoUsuario,new Uri(WebApp.BaseAddressSeguridad), "api/Adscpassws/SalvarToken");


            var claims = new[]
            {
                new Claim(ClaimTypes.Name,usuario.AdpsLogin),
                new Claim(ClaimTypes.SerialNumber,Convert.ToString(guidUsuario))
               
            };



            var principal = new ClaimsPrincipal(new ClaimsIdentity(claims));

           await HttpContext.Authentication.SignInAsync("Cookies", principal, new Microsoft.AspNetCore.Http.Authentication.AuthenticationProperties { IsPersistent = true });

            if (string.IsNullOrEmpty(returnUrl))
            {
                return RedirectToAction(nameof(HomesController.Menu), "Homes");
            }

            return LocalRedirect(returnUrl);

        }

        public async Task<IActionResult> LoginSistema(Login login, string returnUrl = null)
        {

            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(LoginController.Index));
            }

            var response = await apiServicio.ObtenerElementoAsync1<Response>(login,
                                                              new Uri(WebApp.BaseAddressSeguridad),
                                                              "api/Adscpassws/Login");



            if (!response.IsSuccess)
            {
                return RedirectToAction(nameof(LoginController.Index), new { mensaje = response.Message });
            }

            var usuario = JsonConvert.DeserializeObject<Adscpassw>(response.Resultado.ToString());

            var codificar = new Codificar
            {
                Entrada = Convert.ToString(DateTime.Now),
            };

            Guid guidUsuario;
            guidUsuario = Guid.NewGuid();

            var permisoUsuario = new PermisoUsuario
            {
                Usuario = usuario.AdpsLogin,
                Token = Convert.ToString(guidUsuario),
            };

            var salvarToken = await apiServicio.InsertarAsync<Response>(permisoUsuario, new Uri(WebApp.BaseAddressSeguridad), "api/Adscpassws/SalvarToken");


            var claims = new[]
            {
                new Claim(ClaimTypes.Name,usuario.AdpsLogin),
                new Claim(ClaimTypes.SerialNumber,Convert.ToString(guidUsuario))

            };



            var principal = new ClaimsPrincipal(new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme));

            await HttpContext.Authentication.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

            if (string.IsNullOrEmpty(returnUrl))
            {
                return RedirectToAction(nameof(HomesController.Menu), "Homes");
            }

            return LocalRedirect(returnUrl);

        }

        public async Task<IActionResult> Salir()
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
            await HttpContext.Authentication.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction(nameof(LoginController.Index), "Login");
            }
            return RedirectToAction(nameof(HomesController.Menu), "Homes");

        }

        public async Task<Adscpassw> GetAdscPassws(Adscpassw adscpassw)
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<Response> EliminarToken(Adscpassw adscpassw)
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
                    ExceptionTrace = ex,
                    LogCategoryParametre = Convert.ToString(LogCategoryParameter.Edit),
                    LogLevelShortName = Convert.ToString(LogLevelParameter.ERR),
                    UserName = "Usuario APP webappth"
                });

                return null;
            }
        }


    }
}
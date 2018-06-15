using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Principal;
using System.Security.Claims;
using System.Threading;
using bd.webappth.entidades.Negocio;
using bd.webappth.entidades.Utils;
using bd.webappth.servicios.Interfaces;
using bd.webappth.web.Controllers.MVC;
using bd.webapplogin.entidades.Utils;
using bd.webapplogin.entidades.ViewModels;
using bd.log.guardar.ObjectTranfer;
using bd.log.guardar.Enumeradores;
using Newtonsoft.Json;

namespace bd.webappth.web.Controllers
{
    public class HomesController : Controller
    {
        private readonly IApiServicio apiServicio;

        public HomesController(IApiServicio apiServicio)
        {
            this.apiServicio=apiServicio;
        }

        public IActionResult SeccionCerrada()
        {
            return View();
        }


        /// <summary>
        /// Método para mostrar la pantalla de cambiar contraseña
        /// </summary>
        /// <returns></returns>
        [Authorize(Policy = PoliticaSeguridad.TienePermiso)]
        public IActionResult CambiarContrasena()
        {
          return View();
        }

        /// <summary>
        /// Método Cambiar la contraseña
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Authorize(Policy = PoliticaSeguridad.TienePermiso)]
        public async Task<IActionResult> CambiarContrasena(CambiarContrasenaViewModel cambiarContrasenaViewModel)
        {
            try
            {
                if (string.IsNullOrEmpty(cambiarContrasenaViewModel.ConfirmacionContrasena) || string.IsNullOrEmpty(cambiarContrasenaViewModel.ContrasenaActual) || string.IsNullOrEmpty(cambiarContrasenaViewModel.NuevaContrasena))
                {
                    ModelState.AddModelError("", "Debe introducir todos los datos por favor...");
                    return View();
                }

                if (cambiarContrasenaViewModel.NuevaContrasena!=cambiarContrasenaViewModel.ConfirmacionContrasena)
                {
                ModelState.AddModelError("","La contraseña nueva no coincide con la confirmación");
                return View();
                }

                var claim = HttpContext.User.Identities.Where(x => x.NameClaimType == ClaimTypes.Name).FirstOrDefault();
                var token = claim.Claims.Where(c => c.Type == ClaimTypes.SerialNumber).FirstOrDefault().Value;
                var NombreUsuario = claim.Claims.Where(c => c.Type == ClaimTypes.Name).FirstOrDefault().Value;


                Response response = new entidades.Utils.Response();

                cambiarContrasenaViewModel.Usuario = NombreUsuario;
                response = await apiServicio.ObtenerElementoAsync1<Response>(cambiarContrasenaViewModel,
                                                            new Uri(WebApp.BaseAddressSeguridad),
                                                            "api/Adscpassws/CambiarContrasenaUsuariosExternos");
                if (response.IsSuccess)
                {
                    var responseLog = new EntradaLog
                    {
                        ExceptionTrace = null,
                        LogCategoryParametre = Convert.ToString(LogCategoryParameter.Permission),
                        LogLevelShortName = Convert.ToString(LogLevelParameter.ADV),
                        ObjectPrevious = null,
                        ObjectNext = JsonConvert.SerializeObject(response.Resultado),
                    };
                    await apiServicio.SalvarLog<entidades.Utils.Response>(HttpContext, responseLog);
                    return RedirectToActionPermanent("Menu","Homes");
                }
                ModelState.AddModelError("", response.Message);
                return View();

            }
            catch (Exception ex)
            {
                var responseLog = new EntradaLog
                {
                    ExceptionTrace = ex.Message,
                    LogCategoryParametre = Convert.ToString(LogCategoryParameter.Critical),
                    LogLevelShortName = Convert.ToString(LogLevelParameter.ERR),
                    ObjectPrevious = null,
                    ObjectNext = null,
                };
                await apiServicio.SalvarLog<entidades.Utils.Response>(HttpContext, responseLog);

                return BadRequest();
            }
        }


        /// <summary>
        /// Método encargado de listar los sistemas a los que tiene acceso el usuario autenticado
        /// </summary>
        /// <returns></returns>
        [Authorize(Policy = PoliticaSeguridad.TienePermiso)]
        public async Task<IActionResult> Menu()
        {
            try
            {
                var claim = HttpContext.User.Identities.Where(x => x.NameClaimType == ClaimTypes.Name).FirstOrDefault();
                var token = claim.Claims.Where(c => c.Type == ClaimTypes.SerialNumber).FirstOrDefault().Value;
                var NombreUsuario = claim.Claims.Where(c => c.Type == ClaimTypes.Name).FirstOrDefault().Value;

                var lista = new List<Adscsist>();
                try
                {
                    lista = await apiServicio.Listar<Adscsist>(NombreUsuario, new Uri(WebApp.BaseAddressSeguridad), "api/Adscsists/ListarAdscSistemaMiembro");

                    return View(lista);
                }
                catch (Exception )
                {
                  
                    return BadRequest();
                }
            }
            catch (Exception )
            {

                return RedirectToAction(nameof(LoginController.Index), "Login");
            }
            //return View();
        }
        /// <summary>
        /// Método encargado de abrir el sistema que se ha solicitado al hacer click sobre él en la vista
        /// </summary>
        /// <param name="host">El host del donde se encuentra el sistema solicitado se obtiene desde la vista...</param>
        /// <returns></returns>
        [Authorize(Policy = PoliticaSeguridad.TienePermiso)]
        public async Task<ActionResult> AbrirSistema(string host)
        {
          
            try
            {
                var a = new Guid();
                /// <summary>
                /// Se obtiene información del usuario autenticado
                /// </summary>
                var claim = HttpContext.User.Identities.Where(x => x.NameClaimType == ClaimTypes.Name).FirstOrDefault();
                var token = claim.Claims.Where(c => c.Type == ClaimTypes.SerialNumber).FirstOrDefault().Value;
                var NombreUsuario = claim.Claims.Where(c => c.Type == ClaimTypes.Name).FirstOrDefault().Value;

                var permiso = new PermisoUsuario
                {
                    Token = token,
                    Usuario = NombreUsuario,
                };

                /// <summary>
                /// Se válida si el usuario tiene el token válido para realizar la acción de abrir el sistema
                /// </summary>
                var respuesta = apiServicio.ObtenerElementoAsync1<Response>(permiso, new Uri(WebApp.BaseAddressSeguridad), "api/Adscpassws/TienePermisoTemp");
                //respuesta.Result.IsSuccess = true;
                if (respuesta.Result.IsSuccess)
                {
                    a = Guid.NewGuid();

                    var permisoTemp = new PermisoUsuario
                    {
                        Token = Convert.ToString(a),
                        Usuario = NombreUsuario,
                    };
                    /// <summary>
                    /// Se salva un Token temporal en la base de datos por usuario para que al abrir el otro sistema este válide 
                    /// el token fue generado por esta aplicación 
                    /// </summary>
                    var salvarToken = await apiServicio.InsertarAsync<Response>(permisoTemp, new Uri(WebApp.BaseAddressSeguridad), "api/Adscpassws/SalvarTokenTemp");
                    return Redirect(host + "/Login/Login" + "?miembro=" + NombreUsuario + "&token=" + a.ToString());

                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return RedirectToAction(nameof(LoginController.Index), "Login");
             
            }
            //return  Redirect(host+"?miembro=" + NombreUsuario);           
           
        }

    }
}

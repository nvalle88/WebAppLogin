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

namespace bd.webappth.web.Controllers
{
    public class HomesController : Controller
    {
        private readonly IApiServicio apiServicio;

        public HomesController(IApiServicio apiServicio)
        {
            this.apiServicio=apiServicio;
        }

        public IActionResult AccesoDenegado()
        {
            return View();
        }
        /// <summary>
        /// Método encargado de listar los sistemas a los que tiene acceso el usuario autenticado
        /// </summary>
        /// <returns></returns>
        [Authorize(Policy = "EstaAutorizado")]
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
                catch (Exception ex)
                {
                  
                    return BadRequest();
                }
            }
            catch (Exception ex)
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
        [Authorize(Policy = "EstaAutorizado")]
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

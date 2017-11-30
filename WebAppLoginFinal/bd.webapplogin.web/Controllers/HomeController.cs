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

        [Authorize]
        public IActionResult Index()
        {
            //var b = string.Empty;
            var claim = HttpContext.User.Identities.Where(x=>x.NameClaimType==ClaimTypes.Name).FirstOrDefault();
            var token= claim.Claims.Where(c => c.Type == ClaimTypes.SerialNumber).FirstOrDefault().Value;
            var NombreUsuario = claim.Claims.Where(c => c.Type == ClaimTypes.Name).FirstOrDefault().Value;

            //var identity = (ClaimsPrincipal.Current.Claims.Where(x => x.Type == ClaimTypes.Name)).First();
            //var name= claim.Name;
            return View();
        }

        
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
        public IActionResult AccesoDenegado()
        {
            return View();
        }

        public IActionResult Salir()
        {
            return View();
        }

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
                    //await GuardarLogService.SaveLogEntry(new LogEntryTranfer
                    //{
                    //    ApplicationName = Convert.ToString(Aplicacion.WebAppTh),
                    //    Message = "Listando estados civiles",
                    //    ExceptionTrace = ex,
                    //    LogCategoryParametre = Convert.ToString(LogCategoryParameter.NetActivity),
                    //    LogLevelShortName = Convert.ToString(LogLevelParameter.ERR),
                    //    UserName = "Usuario APP webappth"
                    //});
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {

                return RedirectToAction(nameof(LoginController.Index), "Login");
            }
            //return View();
        }

        public async Task<ActionResult> AbrirSistema(string host)
        {
            var a = new Guid();
            var claim = HttpContext.User.Identities.Where(x => x.NameClaimType == ClaimTypes.Name).FirstOrDefault();
            var token = claim.Claims.Where(c => c.Type == ClaimTypes.SerialNumber).FirstOrDefault().Value;
            var NombreUsuario = claim.Claims.Where(c => c.Type == ClaimTypes.Name).FirstOrDefault().Value;

           

            var permiso = new PermisoUsuario
            {
                Token = token,
                Usuario = NombreUsuario,
            };


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

                var salvarToken = await apiServicio.InsertarAsync<Response>(permisoTemp, new Uri(WebApp.BaseAddressSeguridad), "api/Adscpassws/SalvarTokenTemp");
                return Redirect("http://localhost:53318/Login/Login" + "?miembro=" + NombreUsuario + "&token=" + a.ToString());
            }
            else
            {
                return null;
                //context.Fail();
            }
            //return  Redirect(host+"?miembro=" + NombreUsuario);           
           
        }

    }
}

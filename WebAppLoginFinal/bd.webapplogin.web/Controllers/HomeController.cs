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
            //return View();
        }

        public async Task<ActionResult> AbrirSistema(string host)
        {
            var claim = HttpContext.User.Identities.Where(x => x.NameClaimType == ClaimTypes.Name).FirstOrDefault();
            var token = claim.Claims.Where(c => c.Type == ClaimTypes.SerialNumber).FirstOrDefault().Value;
            var NombreUsuario = claim.Claims.Where(c => c.Type == ClaimTypes.Name).FirstOrDefault().Value;

            //return  Redirect(host+"?miembro=" + NombreUsuario);
            return  Redirect("http://localhost:53317/" + "?miembro=" + NombreUsuario);
        }

    }
}

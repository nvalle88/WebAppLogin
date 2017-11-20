using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using bd.webappth.servicios.Interfaces;
using bd.webappth.entidades.Utils;
using bd.webappth.entidades.ViewModels;
using bd.log.guardar.Inicializar;
using System.Security.Claims;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authentication.Cookies;
using bd.webappth.entidades.Negocio;
using Microsoft.AspNetCore.Authorization;

namespace WebAppLogin.Controllers.MVC
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
                                                             "/api/Adscpassws/Login");

           

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

            var salvarToken = await apiServicio.InsertarAsync<Response>(permisoUsuario,new Uri(WebApp.BaseAddressSeguridad), "/api/Adscpassws/SalvarToken");


            var claims = new[]
            {
                new Claim(ClaimTypes.Name,usuario.AdpsLogin),
                new Claim(ClaimTypes.SerialNumber,Convert.ToString(guidUsuario))
               
            };



            var principal = new ClaimsPrincipal(new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme));

           await HttpContext.Authentication.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

            if (string.IsNullOrEmpty(returnUrl))
            {
                return RedirectToAction(nameof(HomesController.Index), "Homes");
            }

            return LocalRedirect(returnUrl);

        }

        public async Task<IActionResult> Salir()
        {
           
            await HttpContext.Authentication.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction(nameof(LoginController.Index), "Login");


        }
    }
}
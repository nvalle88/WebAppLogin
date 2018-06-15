using bd.webappth.entidades.Utils;
using bd.webappth.servicios.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Linq;
using System.Security.Claims;

namespace bd.webappth.web.Models
{

    public class Filtro : IActionFilter
    {

      

        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            try
            {
              
                /// <summary>
                /// Se obtiene el contexto de datos 
                /// </summary>
                /// <returns></returns>
                /// con
                var httpContext = context.HttpContext;
                
                /// <summary>
                /// Se obtiene el path solicitado 
                /// </summary>
                /// <returns></returns>
                var request = httpContext.Request;


                /// <summary>
                /// Se obtiene información del usuario autenticado
                /// </summary>
                /// <returns></returns>
                var claim = context.HttpContext.User.Identities.Where(x => x.NameClaimType == ClaimTypes.Name).FirstOrDefault();
                var token = claim.Claims.Where(c => c.Type == ClaimTypes.SerialNumber).FirstOrDefault().Value;
                var NombreUsuario = claim.Claims.Where(c => c.Type == ClaimTypes.Name).FirstOrDefault().Value;

                var permiso = new PermisoUsuario
                {
                    Contexto = request.Path,
                    Token = token,
                    Usuario = NombreUsuario,
                };

                if (request.Path=="/")
                {
                    var result = new RedirectResult(WebApp.BaseAddressWebAppLogin);
                }
                else
                {
                    ApiServicio a = new ApiServicio();
                    var respuestaToken = a.ObtenerElementoAsync1<Response>(permiso, new Uri(WebApp.BaseAddressSeguridad), "api/Adscpassws/ExisteToken");

                    if (!respuestaToken.Result.IsSuccess)
                    {
                        var result = new ViewResult { ViewName = "SeccionCerrada" };
                        context.Result = result;
                    }
                    else
                    {
                        var respuesta = a.ObtenerElementoAsync1<Response>(permiso, new Uri(WebApp.BaseAddressSeguridad), "api/Adscpassws/TienePermiso");

                        //respuesta.Result.IsSuccess = true;
                        if (!respuesta.Result.IsSuccess)
                        {
                            var result = new ViewResult { ViewName = "AccesoDenegado" };
                            context.Result = result;
                        }
                    }
                }

                /// <summary>
                /// Se valida que la información del usuario actual tenga permiso para acceder al path solicitado... 
                /// </summary>
                /// <returns></returns>


               

            }
            catch (Exception ex)
            {

                //RedirectToActionResult a = new RedirectToActionResult("Index","Login","");
                //context.Result = a;

                var result = new RedirectResult(WebApp.BaseAddressWebAppLogin);
               
                context.Result = result;

            }
           
        }
    }
}

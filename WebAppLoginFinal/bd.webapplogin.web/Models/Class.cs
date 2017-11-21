using bd.webappth.entidades.Utils;
using bd.webappth.servicios.Interfaces;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace bd.webappth.web.Models
{

    

    public class RolesHandler : AuthorizationHandler<RolesRequirement>
    {
        public readonly IApiServicio apiServicio;

        public RolesHandler(IApiServicio apiServicio)
        {
            this.apiServicio = apiServicio;
        }



        protected  override  Task HandleRequirementAsync(AuthorizationHandlerContext context, RolesRequirement requirement)
        {
            try
            {
                //Obtención del Context
                var recurso = context.Resource as Microsoft.AspNetCore.Mvc.Filters.AuthorizationFilterContext;

                var httpContext = recurso.HttpContext;
                var request = httpContext.Request;
                var claim = context.User.Identities.Where(x => x.NameClaimType == ClaimTypes.Name).FirstOrDefault();
                var token = claim.Claims.Where(c => c.Type == ClaimTypes.SerialNumber).FirstOrDefault().Value;
                var NombreUsuario = claim.Claims.Where(c => c.Type == ClaimTypes.Name).FirstOrDefault().Value;

                var permiso = new PermisoUsuario
                {
                    Contexto= request.Path,
                    Token=token,
                    Usuario=NombreUsuario,
                };

               var respuesta=  apiServicio.ObtenerElementoAsync1<Response>(permiso, new Uri(WebApp.BaseAddressSeguridad), "/api/Adscpassws/TienePermiso");

                //respuesta.Result.IsSuccess = true;
                if (respuesta.Result.IsSuccess)
                {
                    context.Succeed(requirement);

                }
                else
                {
                    context.Fail();
                }
                
            }
            catch (Exception ex)
            {
                context.Fail();
                return Task.CompletedTask;
            }
            
            return Task.FromResult(0);
        }
    }
}

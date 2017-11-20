using bd.webappcompartido.entidades.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Claims;

namespace bd.webappcompartido.servicios.Interfaces
{
  public interface ISeguridadServicio
    {
        Response TienePermiso(string controlador,string accion, ClaimsPrincipal user);
        
    }
}

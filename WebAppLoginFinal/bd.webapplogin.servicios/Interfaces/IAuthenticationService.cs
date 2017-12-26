using bd.webapplogin.entidades.LDAP;
using System;
using System.Collections.Generic;
using System.Text;

namespace bd.webapplogin.servicios.Interfaces
{
   public interface IAuthenticationService
    {
        UsuarioLDAP Login(string username, string password);
    }
}

using bd.webapplogin.entidades.LDAP;
using System;
using System.Collections.Generic;
using System.Text;

namespace bd.webapplogin.servicios.Servicios
{
   public class LdapAuthenticationService
    {
        private const string MemberOfAttribute = "memberOf";
        private const string DisplayNameAttribute = "displayName";
        private const string SAMAccountNameAttribute = "sAMAccountName";

        private readonly LdapConfig _config;
        private readonly LdapConnection _connection;

        public LdapAuthenticationService(IOptions<LdapConfig> config)
        {
            _config = config.Value;
            _connection = new LdapConnection
            {
                SecureSocketLayer = true
            };
        }

        public AppUser Login(string username, string password)
        {
            _connection.Connect(_config.Url, LdapConnection.DEFAULT_SSL_PORT);
            _connection.Bind(_config.BindDn, _config.BindCredentials);

            var searchFilter = string.Format(_config.SearchFilter, username);
            var result = _connection.Search(
                _config.SearchBase,
                LdapConnection.SCOPE_SUB,
                searchFilter,
                new[] { MemberOfAttribute, DisplayNameAttribute, SAMAccountNameAttribute },
                false
            );

            try
            {
                var user = result.next();
                if (user != null)
                {
                    _connection.Bind(user.DN, password);
                    if (_connection.Bound)
                    {
                        return new UsuarioLDAP
                        {
                            DisplayName = user.getAttribute(DisplayNameAttribute).StringValue,
                            Username = user.getAttribute(SAMAccountNameAttribute).StringValue,
                        };
                    }
                }
            }
            catch
            {
                throw new Exception("Login failed.");
            }
            _connection.Disconnect();
            return null;
        }

    }
}

using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bd.webappth.web.Models
{
    public class RolesRequirement : IAuthorizationRequirement
    {
        public string Roles { get; private set; }

        public RolesRequirement()
        {
            
        }
    }
}

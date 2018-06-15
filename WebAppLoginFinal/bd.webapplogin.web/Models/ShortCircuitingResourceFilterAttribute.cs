using bd.webappth.entidades.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bd.webapplogin.web.Models
{
    public class ShortCircuitingResourceFilterAttribute : Attribute,
            IResourceFilter
    {
        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            var result = new ViewResult { ViewName = "Index" };
            result.ViewData.Add("Title", "Login");
            result.ViewData.Add("Error", "sfsdfsd");
            context.Result = result;
        }

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
        }
    }
}

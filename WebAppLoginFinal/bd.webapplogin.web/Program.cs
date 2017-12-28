using System.IO;
using Microsoft.AspNetCore.Hosting;
using bd.webappcompartido.web;

namespace bd.webappth.web
{
    /// <summary>
    /// Se inicializa Asp.Net Core
    /// Para más información visitar:https://docs.microsoft.com/en-us/aspnet/core/fundamentals/?tabs=aspnetcore2x
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseApplicationInsights()
                .Build();

            host.Run();
        }
    }
}

using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using WebBase.EntityFramework;

namespace WebBase.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = BuildWebHost(args);

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var webBaseContext = services.GetRequiredService<WebBaseContext>();
                    WebBaseContextSeed.Seed(webBaseContext);
                }
                catch (Exception ex)
                {
                    Console.Out.WriteLine(ex);
                }
            }

            host.Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}

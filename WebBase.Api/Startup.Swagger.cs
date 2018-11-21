using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.Swagger;
using System.IO;

namespace WebBase.Api
{
    public partial class Startup
    {
        private string _version = "1.0";

        public void Swagger(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc($"v{_version}", new Info
                {
                    Version = $"v{_version}",
                    Title = "Web Base API"
                });

                var basePath = PlatformServices.Default.Application.ApplicationBasePath;
                var xmlPath = Path.Combine(basePath, "WebBase.Api.xml");
                c.IncludeXmlComments(xmlPath);
                //c.AddSecurityDefinition("Bearer", new ApiKeyScheme() { In = "header", Description = "Please insert: \"bearer [access_token]\"", Name = "Authorization", Type = "apiKey" });
                //c.DescribeAllEnumsAsStrings();
            });
        }

        public void Swagger(IApplicationBuilder app)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint($"/swagger/v{_version}/swagger.json", $"Web Base V{_version}");
            });

        }
    }
}

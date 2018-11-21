using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using WebBase.AutoMapper;

namespace WebBase.Api
{
    public partial class Startup
    {
        public void AutoMapper(IServiceCollection services)
        {
            services.AddAutoMapper();

            Mapper.Initialize(config =>
            {
                config.AddProfile(new CategoryProfile());
                config.AddProfile(new BookProfile());
            });

            services.AddSingleton(new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new CategoryProfile());
                cfg.AddProfile(new BookProfile());
            }).CreateMapper());
        }
    }
}

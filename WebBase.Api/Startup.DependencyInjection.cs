using Microsoft.Extensions.DependencyInjection;
using WebBase.Repositories;
using WebBase.Repositories.Implement;
using WebBase.Services;
using WebBase.Services.Implement;

namespace WebBase.Api
{
    public partial class Startup
    {
        public void DependencyInjection(IServiceCollection services)
        {
            #region Services

            services.AddScoped<ICategoryService, CategoryService>();

            #endregion

            #region Repoitories

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IBookRepository, BookRepository>();

            #endregion
        }
    }
}

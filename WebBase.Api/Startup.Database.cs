using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebBase.Configuration;
using WebBase.EntityFramework;

namespace WebBase.Api
{
    public partial class Startup
    {
        private static readonly string DbConnection = WebBaseConfiguration.DbConnection;

        public void Database(IServiceCollection services)
        {
            services.AddDbContext<WebBaseContext>(c =>
            {
                c.UseSqlServer(DbConnection,
                    builder => builder.UseRowNumberForPaging());
            });
        }
    }
}

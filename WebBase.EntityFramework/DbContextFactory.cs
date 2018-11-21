using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using WebBase.Configuration;

namespace WebBase.EntityFramework
{
    public class DbContextFactory : IDesignTimeDbContextFactory<WebBaseContext>
    {
        private static readonly string DbConnection = WebBaseConfiguration.DbConnection;

        public WebBaseContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<WebBaseContext>();
            builder.UseSqlServer(DbConnection);
            return new WebBaseContext(builder.Options);
        }
    }
}

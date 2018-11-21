using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using WebBase.Entities;
using WebBase.EntityFramework.Mapping;

namespace WebBase.EntityFramework
{
    public class WebBaseContext : DbContext
    {
        public WebBaseContext(DbContextOptions<WebBaseContext> options) : base(options)
        {
        }

        public DbSet<CategoryEntity> Categories { get; set; }

        public DbSet<BookEntity> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            Mapping(modelBuilder);
        }

        private static void Mapping(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryEMap());
            modelBuilder.ApplyConfiguration(new BookEMap());
        }
    }
}

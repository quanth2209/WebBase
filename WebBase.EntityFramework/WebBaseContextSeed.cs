using System.Collections.Generic;
using System.Linq;
using WebBase.Core;
using WebBase.Entities;

namespace WebBase.EntityFramework
{
    public class WebBaseContextSeed
    {
        public static void Seed(WebBaseContext dbContext)
        {
            dbContext.Database.EnsureCreated();

            SeedCategory(dbContext);

            dbContext.SaveChanges();
        }

        private static void SeedCategory(WebBaseContext dbContext)
        {
            if(dbContext.Categories.Any())
                return;

            dbContext.Add(new CategoryEntity
            {
                Name = "Category 1",
                Status = WebBaseEnums.Status.Active,
                CreationDate = WebBaseUtils.Now(),
                Books = new List<BookEntity>
                {
                    new BookEntity
                    {
                        Name = "Book 1",
                        Description = "This is book 1",
                        Author = "Author 1",
                        Status = WebBaseEnums.Status.Active,
                        ReleaseDate = WebBaseUtils.Now(),
                        CreationDate = WebBaseUtils.Now()
                    },
                    new BookEntity
                    {
                        Name = "Book 2",
                        Description = "This is book 2",
                        Author = "Author 1",
                        Status = WebBaseEnums.Status.Active,
                        ReleaseDate = WebBaseUtils.Now(),
                        CreationDate = WebBaseUtils.Now()
                    },
                    new BookEntity
                    {
                        Name = "Book 3",
                        Description = "This is book 3",
                        Author = "Author 2",
                        Status = WebBaseEnums.Status.Active,
                        ReleaseDate = WebBaseUtils.Now(),
                        CreationDate = WebBaseUtils.Now()
                    }
                }
            });

            dbContext.Add(new CategoryEntity
            {
                Name = "Category 1",
                Status = WebBaseEnums.Status.Active,
                CreationDate = WebBaseUtils.Now(),
                Books = new List<BookEntity>
                {
                    new BookEntity
                    {
                        Name = "Book 4",
                        Description = "This is book 4",
                        Author = "Author 1",
                        Status = WebBaseEnums.Status.Active,
                        ReleaseDate = WebBaseUtils.Now(),
                        CreationDate = WebBaseUtils.Now()
                    },
                    new BookEntity
                    {
                        Name = "Book 5",
                        Description = "This is book 5",
                        Author = "Author2",
                        Status = WebBaseEnums.Status.Active,
                        ReleaseDate = WebBaseUtils.Now(),
                        CreationDate = WebBaseUtils.Now()
                    }
                }
            });
        }
    }
}

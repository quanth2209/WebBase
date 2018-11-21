using WebBase.Entities;
using WebBase.EntityFramework;
using WebBase.Repositories.Implement.Base;

namespace WebBase.Repositories.Implement
{
    public class CategoryRepository : BaseRepository<CategoryEntity>, ICategoryRepository
    {
        public CategoryRepository(WebBaseContext context) : base(context)
        {
        }
    }
}

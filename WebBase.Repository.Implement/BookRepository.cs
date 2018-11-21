using WebBase.Entities;
using WebBase.EntityFramework;
using WebBase.Repositories.Implement.Base;

namespace WebBase.Repositories.Implement
{
    public class BookRepository : BaseRepository<BookEntity>, IBookRepository
    {
        public BookRepository(WebBaseContext context) : base(context)
        {
        }
    }
}

using System.Collections.Generic;
using WebBase.Models.Book;

namespace WebBase.Models.Category
{
    public class CategoryWebDetailsModel : CategoryWebModel
    {
        public ICollection<BookWebModel> Books { get; set; }
    }
}

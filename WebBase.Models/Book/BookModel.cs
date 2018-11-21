using System;
using WebBase.Models.Base;

namespace WebBase.Models.Book
{
    public class BookModel : BaseModel
    {
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Author { get; set; }

        public DateTime ReleaseDate { get; set; }

        public long CategoryId { get; set; }
    }
}

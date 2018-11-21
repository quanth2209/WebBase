using System;
using WebBase.Core;

namespace WebBase.Models.Book
{
    public class BookCreateModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Author { get; set; }

        public DateTime ReleaseDate { get; set; }

        public long CategoryId { get; set; }

        public WebBaseEnums.Status Status { get; set; }
    }
}

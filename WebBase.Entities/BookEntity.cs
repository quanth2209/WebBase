using System;
using WebBase.Entities.Base;

namespace WebBase.Entities
{
    public class BookEntity : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Author { get; set; }

        public DateTime ReleaseDate { get; set; }

        public CategoryEntity Category { get; set; }
        public long CategoryId { get; set; }
    }
}

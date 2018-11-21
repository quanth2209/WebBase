using System.Collections.Generic;
using WebBase.Entities.Base;

namespace WebBase.Entities
{
    public class CategoryEntity : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<BookEntity> Books { get; set; }
    }
}

using System;
using WebBase.Models.Base;

namespace WebBase.Models.Category
{
    public class CategoryModel : BaseModel
    {
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }

        public string Name { get; set; }
    }
}

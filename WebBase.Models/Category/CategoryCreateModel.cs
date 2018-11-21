using WebBase.Core;

namespace WebBase.Models.Category
{
    public class CategoryCreateModel
    {
        public string Name { get; set; }

        public WebBaseEnums.Status Status { get; set; }
    }
}

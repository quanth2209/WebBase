using WebBase.Core;

namespace WebBase.Entities.Base
{
    public class BaseEntity : BaseIdEntity
    {
        public WebBaseEnums.Status Status { get; set; }
    }
}

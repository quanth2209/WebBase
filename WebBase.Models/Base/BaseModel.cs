using WebBase.Core;

namespace WebBase.Models.Base
{
    public class BaseModel: BaseIdModel
    {
        public WebBaseEnums.Status Status { get; set; }
    }
}

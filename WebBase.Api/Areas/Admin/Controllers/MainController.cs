using Microsoft.AspNetCore.Mvc;
using WebBase.Api.Areas.Admin.Controllers.Base;

namespace WebBase.Api.Areas.Admin.Controllers
{
    [Route("admin/api/main")]
    public class MainController : AdminBaseController
    {
        public MainController()
        {
        }

        [HttpGet("test")]
        public IActionResult Test()
        {
            return Ok();
        }
    }
}
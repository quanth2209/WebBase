using Microsoft.AspNetCore.Mvc;
using WebBase.Api.Areas.Admin.Controllers.Base;
using WebBase.Models.Base;
using WebBase.Models.Category;
using WebBase.Services;

namespace WebBase.Api.Areas.Admin.Controllers
{
    [Route("admin/api/category")]
    public class CategoryController : AdminBaseController
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("get")]
        public IActionResult Get()
        {
            return Ok(_categoryService.Get());
        }

        [HttpGet("get/{id}")]
        public IActionResult Get(long id)
        {
            return Ok(_categoryService.Get(id));
        }

        [HttpPost("create")]
        public IActionResult Create([FromBody]CategoryCreateModel model)
        {
            return Ok(_categoryService.Create(model));
        }

        [HttpPut("update")]
        public IActionResult Update([FromBody]CategoryUpdateModel model)
        {
            return Ok(_categoryService.Update(model));
        }

        [HttpPut("update-status")]
        public IActionResult Update([FromBody]BaseModel model)
        {
            return Ok(_categoryService.UpdateStatus(model));
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(long id)
        {
            return Ok(_categoryService.Delete(id));
        }
    }
}
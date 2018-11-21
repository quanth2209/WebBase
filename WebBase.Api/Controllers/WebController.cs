using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebBase.Api.Controllers.Base;
using WebBase.Services;

namespace WebBase.Api.Controllers
{
    [Route("api/book")]
    public class WebController : BaseController
    {
        private readonly ICategoryService _categoryService;

        public WebController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
        }

        [HttpGet("get-category")]
        public IActionResult GetCategory()
        {
            return Ok(_categoryService.GetWeb());
        }

        [HttpGet("get-category-details")]
        public IActionResult GetCategoryDetails()
        {
            return Ok(_categoryService.GetWebDetails());
        }

        [HttpGet("get-category/{id}")]
        public IActionResult GetCategory(long id)
        {
            return Ok(_categoryService.GetWeb(id));
        }

        [HttpGet("get-category-details/{id}")]
        public IActionResult GetCategoryDetails(long id)
        {
            return Ok(_categoryService.GetWebDetails(id));
        }

        //[HttpGet("get-book")]
        //public IActionResult GetBook()
        //{
        //    var query = _bookRepository.Get()
        //        .Where(x => x.Status == WebBaseEnums.Status.Active)
        //        .Include(x => x.Category)
        //        .ToList();

        //    return Ok(_mapper.Map<List<BookWebModel>>(query));
        //}

        //[HttpGet("get-book-project-to")]
        //public IActionResult GetBook2()
        //{
        //    var query = _bookRepository.Get()
        //        .Where(x => x.Status == WebBaseEnums.Status.Active)
        //        .ProjectTo<BookWebModel>()
        //        .ToList();

        //    return Ok(query);
        //}

        //[HttpGet("get-book/{id}")]
        //public IActionResult GetBook(long id)
        //{
        //    var book = _bookRepository.Get()
        //        .Include(x => x.Category)
        //        .FirstOrDefault(x => x.Status == WebBaseEnums.Status.Active && x.Id == id);

        //    if (book == null)
        //        throw new WebBaseExceptions("Not found.");

        //    return Ok(_mapper.Map<BookWebModel>(book));
        //}
    }
}
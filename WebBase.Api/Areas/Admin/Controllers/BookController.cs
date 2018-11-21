using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebBase.Api.Areas.Admin.Controllers.Base;
using WebBase.Core;
using WebBase.Core.Exceptions;
using WebBase.Entities;
using WebBase.EntityFramework;
using WebBase.Models.Base;
using WebBase.Models.Book;

namespace WebBase.Api.Areas.Admin.Controllers
{
    [Route("admin/api/book")]
    public class BookController : AdminBaseController
    {
        private readonly WebBaseContext _webBaseContext;
        private readonly IMapper _mapper;

        public BookController(WebBaseContext webBaseContext, IMapper mapper)
        {
            _webBaseContext = webBaseContext;
            _mapper = mapper;
        }

        [HttpGet("get")]
        public IActionResult Get()
        {
            var query = _webBaseContext.Books
                .Where(x => x.Status != WebBaseEnums.Status.Block)
                .ToList();

            return Ok(_mapper.Map<ICollection<BookModel>>(query));
        }

        [HttpGet("get/{id}")]
        public IActionResult Get(long id)
        {
            var query = _webBaseContext.Books
                .FirstOrDefault(x => x.Status != WebBaseEnums.Status.Block && x.Id == id);

            if (query == null)
                throw new WebBaseExceptions("Not found.");

            return Ok(_mapper.Map<BookModel>(query));
        }

        [HttpPost("create")]
        public IActionResult Create([FromBody]BookCreateModel model)
        {
            var book = _mapper.Map<BookEntity>(model);
            book.CreationDate = WebBaseUtils.Now();

            _webBaseContext.Entry(book).State = EntityState.Added;
            _webBaseContext.SaveChanges();

            return Ok(_mapper.Map<BookModel>(book));
        }

        [HttpPut("update")]
        public IActionResult Update([FromBody]BookUpdateModel model)
        {
            var book = _webBaseContext.Books
                .FirstOrDefault(x => x.Status != WebBaseEnums.Status.Block && x.Id == model.Id);

            if (book == null)
                throw new WebBaseExceptions("Not found.");

            _mapper.Map(model, book);
            book.ModificationDate = WebBaseUtils.Now();

            _webBaseContext.Entry(book).State = EntityState.Modified;
            _webBaseContext.SaveChanges();

            return Ok(_mapper.Map<BookModel>(book));
        }

        [HttpPut("update-status")]
        public IActionResult Update([FromBody]BaseModel model)
        {
            var book = _webBaseContext.Books
                .FirstOrDefault(x => x.Status != WebBaseEnums.Status.Block && x.Id == model.Id);

            if (book == null)
                throw new WebBaseExceptions("Not found.");

            _mapper.Map(model, book);
            book.ModificationDate = WebBaseUtils.Now();

            _webBaseContext.Entry(book).State = EntityState.Modified;
            _webBaseContext.SaveChanges();

            return Ok(_mapper.Map<BookModel>(book));
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(long id)
        {
            var book = _webBaseContext.Books
                .FirstOrDefault(x => x.Status != WebBaseEnums.Status.Block && x.Id == id);

            if (book == null)
                throw new WebBaseExceptions("Not found.");

            book.Status = WebBaseEnums.Status.Block;
            book.ModificationDate = WebBaseUtils.Now();

            _webBaseContext.Entry(book).State = EntityState.Modified;
            _webBaseContext.SaveChanges();

            return Ok(book.Id);
        }
    }
}
using AutoMapper;
using WebBase.Entities;
using WebBase.Models.Base;
using WebBase.Models.Book;

namespace WebBase.AutoMapper
{
    public class BookProfile : Profile
    {
        public BookProfile()
        {
            CreateMap<BookEntity, BookModel>();

            CreateMap<BookCreateModel, BookEntity>();

            CreateMap<BookUpdateModel, BookEntity>();

            CreateMap<BaseModel, BookEntity>();


            CreateMap<BookEntity, BookWebModel>()
                .ForMember(x => x.CategoryName, y => y.MapFrom(z => z.Category.Name));
        }
    }
}

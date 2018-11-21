using AutoMapper;
using WebBase.Entities;
using WebBase.Models.Base;
using WebBase.Models.Category;

namespace WebBase.AutoMapper
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryEntity, CategoryModel>();

            CreateMap<CategoryCreateModel, CategoryEntity>();

            CreateMap<CategoryUpdateModel, CategoryEntity>();

            CreateMap<BaseModel, CategoryEntity>();


            CreateMap<CategoryEntity, CategoryWebModel>();

            CreateMap<CategoryEntity, CategoryWebDetailsModel>();
        }
    }
}

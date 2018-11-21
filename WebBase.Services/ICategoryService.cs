using System.Collections.Generic;
using WebBase.Models.Base;
using WebBase.Models.Category;

namespace WebBase.Services
{
    public interface ICategoryService
    {
        List<CategoryModel> Get();

        CategoryModel Get(long id);

        CategoryModel Create(CategoryCreateModel model);

        CategoryModel Update(CategoryUpdateModel model);

        CategoryModel UpdateStatus(BaseModel model);

        long Delete(long id);

        List<CategoryWebModel> GetWeb();

        List<CategoryWebDetailsModel> GetWebDetails();

        CategoryWebModel GetWeb(long id);

        CategoryWebDetailsModel GetWebDetails(long id);
    }
}

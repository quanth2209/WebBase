using AutoMapper;
using AutoMapper.QueryableExtensions;
using System.Collections.Generic;
using System.Linq;
using WebBase.Core;
using WebBase.Core.Exceptions;
using WebBase.Entities;
using WebBase.Models.Base;
using WebBase.Models.Category;
using WebBase.Repositories;

namespace WebBase.Services.Implement
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public List<CategoryModel> Get()
        {
            return _categoryRepository.Get()
                .ProjectTo<CategoryModel>()
                .ToList();
        }

        public CategoryModel Get(long id)
        {
            var category = _categoryRepository.Get(id);

            if(category == null)
                throw new WebBaseExceptions("Not found.");

            return _mapper.Map<CategoryModel>(category);
        }

        public CategoryModel Create(CategoryCreateModel model)
        {
            var category = _mapper.Map<CategoryEntity>(model);

            _categoryRepository.Create(category);
            _categoryRepository.SaveChanges();

            return _mapper.Map<CategoryModel>(category);
        }

        public CategoryModel Update(CategoryUpdateModel model)
        {
            var category = _categoryRepository.Get(model.Id);

            if (category == null)
                throw new WebBaseExceptions("Not found.");

            _mapper.Map(model, category);

            category.ModificationDate = WebBaseUtils.Now();

            _categoryRepository.Update(category);
            _categoryRepository.SaveChanges();

            return _mapper.Map<CategoryModel>(category);
        }

        public CategoryModel UpdateStatus(BaseModel model)
        {
            var category = _categoryRepository.Get(model.Id);

            if (category == null)
                throw new WebBaseExceptions("Not found.");

            _mapper.Map(model, category);

            category.ModificationDate = WebBaseUtils.Now();

            _categoryRepository.Update(category);
            _categoryRepository.SaveChanges();

            return _mapper.Map<CategoryModel>(category);
        }

        public long Delete(long id)
        {
            var category = _categoryRepository.Get(id);

            if (category == null)
                throw new WebBaseExceptions("Not found.");

            _categoryRepository.Delete(category);
            _categoryRepository.SaveChanges();

            return category.Id;
        }

        public List<CategoryWebModel> GetWeb()
        {
            return _categoryRepository.Get()
                .Where(x => x.Status == WebBaseEnums.Status.Active)
                .ProjectTo<CategoryWebModel>()
                .ToList();
        }

        public List<CategoryWebDetailsModel> GetWebDetails()
        {
            return _categoryRepository.Get()
                .ProjectTo<CategoryWebDetailsModel>()
                .ToList();
        }

        public CategoryWebModel GetWeb(long id)
        {
            var category = _categoryRepository.Get(id);

            if (category == null)
                throw new WebBaseExceptions("Not found.");

            if (category.Status != WebBaseEnums.Status.Active)
                throw new WebBaseExceptions("Not found.");

            return _mapper.Map<CategoryWebModel>(category);
        }

        public CategoryWebDetailsModel GetWebDetails(long id)
        {
            var category = _categoryRepository.Get()
                .Where(x => x.Status == WebBaseEnums.Status.Active && x.Id == id)
                .ProjectTo<CategoryWebDetailsModel>()
                .FirstOrDefault();

            if (category == null)
                throw new WebBaseExceptions("Not found.");

            return category;
        }
    }
}

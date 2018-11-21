using System;
using System.Linq;
using System.Linq.Expressions;
using WebBase.Entities.Base;

namespace WebBase.Repositories.Base
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        IQueryable<T> Get();

        T Get(long id);

        void Create(T entity);

        void Update(T entity);

        void Delete(T entity);

        void SaveChanges();
    }
}

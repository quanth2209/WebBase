using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using WebBase.Core;
using WebBase.Entities.Base;
using WebBase.EntityFramework;
using WebBase.Repositories.Base;

namespace WebBase.Repositories.Implement.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly WebBaseContext _context;

        public BaseRepository(WebBaseContext context)
        {
            _context = context;
        }

        public IQueryable<T> Get()
        {
            return _context.Set<T>().Where(x => x.Status != WebBaseEnums.Status.Block);
        }
        
        public T Get(long id)
        {
            return _context.Set<T>().Find(id);
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> criteria)
        {
            return _context.Set<T>().Where(criteria).AsQueryable();
        }
        
        public void Create(T entity)
        {
            entity.CreationDate = WebBaseUtils.Now();
            _context.Entry(entity).State = EntityState.Added;
        }

        public void Update(T entity)
        {
            entity.ModificationDate = WebBaseUtils.Now();
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            entity.Status = WebBaseEnums.Status.Block;
            entity.ModificationDate = WebBaseUtils.Now();
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}

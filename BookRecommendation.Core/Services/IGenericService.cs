using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookRecommendation.Core.Services
{
    public interface IGenericService<TEntity> where TEntity : class,new()
    {
        IQueryable<TEntity> GetAllAsync();
        TEntity GetById(int id);
        TEntity GetByAnyQuery(Expression<Func<TEntity, bool>> expression);
        IQueryable<TEntity> GetAllAnyQuery(Expression<Func<TEntity, bool>> expression);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
    }
}

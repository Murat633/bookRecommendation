using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookRecommendation.Core.Repositories
{
    public interface IGenericRepository<TEntity> 
        where TEntity : class,new()
    {

        Task<IQueryable<TEntity>> GetAllAsync();
        Task<TEntity> GetById(int id);
        Task<TEntity> GetByAnyQuery(Expression<Func<TEntity, bool>> expression);
        Task<IQueryable<TEntity>> GetAllAnyQuery(Expression<Func<TEntity, bool>> expression);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
    }
}

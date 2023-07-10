using BookRecommendation.Core.Repositories;
using BookRecommendation.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookRecommendation.Service.Services
{
    public class GenericService<TEntity> : IGenericService<TEntity> where TEntity : class, new()
    {
        public IGenericRepository<TEntity> _repository;
        public GenericService(IGenericRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public void Add(TEntity entity)
        {
            _repository.Add(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public IQueryable<TEntity> GetAllAnyQuery(Expression<Func<TEntity, bool>> expression)
        {
            return _repository.GetAllAnyQuery(expression).Result;
        }

        public IQueryable<TEntity> GetAllAsync()
        {
            return _repository.GetAllAsync().Result;
        }

        public TEntity GetByAnyQuery(Expression<Func<TEntity, bool>> expression)
        {
            return _repository.GetByAnyQuery(expression).Result;
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id).Result;
        }

        public void Update(TEntity entity)
        {
            _repository.Update(entity);
        }
    }
}

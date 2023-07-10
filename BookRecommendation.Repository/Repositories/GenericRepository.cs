using BookRecommendation.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookRecommendation.Repository.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : class, new()
    {

        public DbContext _context;
        public DbSet<TEntity> _dbSet;

        public GenericRepository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(int id)
        {
            var entity = _dbSet.Find(id);
            _dbSet.Remove(entity);
        }

        public Task<IQueryable<TEntity>> GetAllAnyQuery(Expression<Func<TEntity, bool>> expression)
        {
            var result = _dbSet.Where(expression).AsQueryable();
            return Task.FromResult(result);
        }

        public Task<IQueryable<TEntity>> GetAllAsync()
        {
            var result = _dbSet.AsQueryable();
            return Task.FromResult(result);
        }

        public Task<TEntity> GetByAnyQuery(Expression<Func<TEntity, bool>> expression)
        {
            var result = _dbSet.Where(expression).FirstOrDefault();
            return Task.FromResult(result);
        }

        public Task<TEntity> GetById(int id)
        {
            var result = _dbSet.Find(id);
            return Task.FromResult(result);
        }

        public void Update(TEntity entity)
        {
            _dbSet.AddOrUpdate(entity);
        }
    }
}

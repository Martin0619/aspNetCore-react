using System;
using System.Linq;
using System.Linq.Expressions;
using Contract;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly DataContext _context;
        public RepositoryBase(DataContext context)
        {
            this._context = context;
        }

        public IQueryable<TEntity> FindAll(bool trackChanges)
        {
            var queryableEntities = _context.Set<TEntity>();
            return trackChanges
                ? queryableEntities
                : queryableEntities.AsNoTracking();
        }

        public IQueryable<TEntity> FindByCondition(
            Expression<Func<TEntity, bool>> expression,
            bool trackChanges
        )
        {
            var queryableEntities = _context.Set<TEntity>()
                                            .Where(expression);
            return trackChanges
                ? queryableEntities
                : queryableEntities.AsNoTracking();
        }
    }
}
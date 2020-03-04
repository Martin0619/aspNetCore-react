using System;
using System.Linq;
using System.Linq.Expressions;

namespace Contract
{
    public interface IRepositoryBase<TEntity>
    {
        IQueryable<TEntity> FindAll(bool trackChanges);
        IQueryable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> expression, bool trackChanges);
    }
}
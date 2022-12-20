using System.Linq.Expressions;

namespace BumboData.Interfaces.Repositories;

public interface IRepository<TEntity> : IRepository<TEntity, int>
{

}

// Implements basic repository actions interface
public interface IRepository<TEntity, TKey>
{
    public TEntity? Get(TKey id);
    public TEntity? Get(Expression<Func<TEntity, bool>> predicate);
    public IEnumerable<TEntity> GetList();
    public IEnumerable<TEntity> GetList(int start, int amount);
    public IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> predicate);
    public TEntity Create(TEntity entity);
    public TEntity Update(TEntity entity);
    public void Delete(TEntity entity);
}
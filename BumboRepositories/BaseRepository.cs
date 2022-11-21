using System.Linq.Expressions;
using BumboData;
using BumboData.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BumboRepositories;

public interface IRepository<TEntity>: IRepository<TEntity, int>
{
    
}

// Implements basic repository actions interface
public interface IRepository<TEntity, TKey>
{
    public TEntity? Get(TKey id);
    public TEntity? Get(Expression<Func<TEntity, bool>> predicate);
    public IEnumerable<TEntity> GetList();
    public IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> predicate);
    public TEntity Create(TEntity entity);
    public TEntity Update(TEntity entity);
    public void Delete(TEntity entity);
}

public abstract class Repository<TEntity> : Repository<TEntity, int>
    where TEntity : class, IEntity<int>
{
    protected Repository(BumboContext context)
        : base(context)
    {
    }
}

// Adds basic repository functionality
public abstract class Repository<TEntity, TKey> : IRepository<TEntity, TKey>
    where TEntity : class, IEntity<TKey>
{
    private DbSet<TEntity> _dbSet;

    protected Repository(BumboContext context)
    {
        Context = context;
    }

    protected BumboContext Context { get; init; }

    protected DbSet<TEntity> DbSet => _dbSet ??= Context.Set<TEntity>();

    public virtual TEntity? Get(TKey id) =>
        DbSet
            .AsQueryable()
            .FirstOrDefault(i => i.Id.Equals(id));

    public virtual TEntity? Get(Expression<Func<TEntity, bool>> predicate) =>
        DbSet
            .AsQueryable()
            .FirstOrDefault(predicate);

    public virtual IEnumerable<TEntity> GetList() => DbSet
        .AsQueryable()
        .ToList();

    public virtual IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> predicate) =>
        DbSet
            .AsQueryable()
            .Where(predicate)
            .ToList();

    public virtual TEntity Create(TEntity entity)
    {
        DbSet.Add(entity);
        Context.SaveChanges();
        return entity;
    }

    public virtual TEntity Update(TEntity entity)
    {
        bool IsBeingTracked(TEntity e) => DbSet.Local.Any(i => i == e);

        // Fix duplicate tracking issues
        if (IsBeingTracked(entity))
        {
            Context.Entry(entity).CurrentValues.SetValues(entity);
        }
        else
        {
            Context.Update(entity);
        }

        Context.SaveChanges();
        return entity;
    }

    public virtual void Delete(TEntity entity)
    {
        Context.Remove(entity);
        Context.SaveChanges();
    }
}
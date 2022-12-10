using Database;
using Database.Entity.Root;
using Microsoft.EntityFrameworkCore;

namespace Repositories.RepositoryRoot;

public class Repository<T, TKey> : IRepository<T, TKey> where T : AggressiveRoot<TKey>
{
    private readonly ApplicationDbContext _dbContext;

    public Repository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    protected DbSet<T> DbSet => _dbContext.Set<T>();
    
    public IQueryable<T> GetAll()
    {
        return _dbContext.Set<T>();
    }

    public void Add(T entity)
    {
        entity.CreatedAt = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
        _dbContext.Add(entity);
    }

    public void Update(T entity)
    {
        entity.UpdatedAt = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
        _dbContext.Update(entity);
    }

    public void Delete(T entity)
    {
        _dbContext.Remove(entity);
    }
}
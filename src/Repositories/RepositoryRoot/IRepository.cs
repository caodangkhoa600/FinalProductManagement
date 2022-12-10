using Database.Entity.Root;

namespace Repositories.RepositoryRoot;

public interface IRepository<T, Key> 
    where T : AggressiveRoot<Key>
{
    IQueryable<T> GetAll();
    
    void Add(T entity);
    
    void Update(T entity);
    
    void Delete(T entity);
}
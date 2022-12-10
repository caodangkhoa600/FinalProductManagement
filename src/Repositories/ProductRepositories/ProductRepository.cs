using Database;
using Database.Entity;
using Repositories.RepositoryRoot;

namespace Repositories.ProductRepositories;

public class ProductRepository : Repository<Product, string>, IProductRepository
{
    public ProductRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public IQueryable<Product> GetAllProducts()
    {
        return GetAll();
    }

    public Product AddProduct(Product product)
    {
        Add(product);
        return product;
    }

    public Product UpdateProduct(Product product)
    {
        Update(product);
        return product;
    }

    public Product? GetProductById(string id)
    {
        return GetAllProducts().FirstOrDefault(p => p.Id == id);
    }
}
using Database.Entity;
using Repositories.RepositoryRoot;

namespace Repositories.ProductRepositories;

public interface IProductRepository : IRepository<Product, string>
{
    IQueryable<Product> GetAllProducts();
    Product AddProduct(Product product);
    Product UpdateProduct(Product product);
    Product? GetProductById(string id);
}
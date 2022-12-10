
using Database.Entity;

namespace Services.ProductServices;

public interface IProductService
{
    IQueryable<Product> GetAllProducts();
    Product AddProduct(Product product);
    Product UpdateProduct(Product product);
    Product UpdateProductQuantity(string productId, int quantity);
    Product? GetProductById(string id);
}
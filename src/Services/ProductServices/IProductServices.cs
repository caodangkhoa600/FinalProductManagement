
using Database.Entity;
using Models.Product;

namespace Services.ProductServices;

public interface IProductServices
{
    IQueryable<Product> GetAllProducts();
    Product AddProduct(Product product);
    Product UpdateProduct(Product product);
    Product UpdateProductQuantity(string productId, int quantity);
    Product? GetProductById(string id);
    Task<Order> BuyProduct(BuyProductViewModel productViewModel);
}
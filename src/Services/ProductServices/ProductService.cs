using Database.Entity;
using UnitOfWork;

namespace Services.ProductServices;

public class ProductService : IProductService
{
    private readonly IUnitOfWork _unitOfWork;
    public ProductService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public IQueryable<Product> GetAllProducts()
    {
        return _unitOfWork.ProductRepository.GetAllProducts();
    }

    public Product AddProduct(Product product)
    {
        _unitOfWork.BeginTransaction();
        var entityProduct = _unitOfWork.ProductRepository
            .GetAllProducts()
            .FirstOrDefault(p => p.Name == product.Name);
        if (entityProduct == null)
        {
            _unitOfWork.ProductRepository.AddProduct(product);
        }
        else
        {
            entityProduct.Quantity += product.Quantity;
            _unitOfWork.ProductRepository.UpdateProduct(product);
        }
        _unitOfWork.SaveChanges();

        
        var productImported = new ProductImportRecord
        {
            ProductId = product.Id,
            Quantity = product.Quantity 
        };

        _unitOfWork.ProductImportRepository.AddProductImport(productImported);
        _unitOfWork.SaveChanges();
        _unitOfWork.CommitTransaction();
        return product;
    }

    public Product UpdateProduct(Product product)
    {
        _unitOfWork.ProductRepository.UpdateProduct(product);
        _unitOfWork.SaveChanges();
        return product;
    }

    public Product UpdateProductQuantity(string productId, int quantity)
    {
        _unitOfWork.BeginTransaction();
        var product = _unitOfWork.ProductRepository.GetAllProducts().First(p => p.Id == productId);
        product.Quantity += quantity;
        UpdateProduct(product);
        var importedProductRow = new ProductImportRecord()
        {
            ProductId = productId,
            Quantity = product.Quantity
        };
        _unitOfWork.ProductImportRepository.AddProductImport(importedProductRow);
        _unitOfWork.CommitTransaction();
        return product;
    }

    public Product? GetProductById(string id)
    {
        return _unitOfWork.ProductRepository.GetProductById(id);

    }
}
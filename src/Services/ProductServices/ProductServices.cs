using Database.Entity;
using Models.Product;
using UnitOfWork;

namespace Services.ProductServices;

public class ProductServices : IProductServices
{
    private readonly IUnitOfWork _unitOfWork;
    public ProductServices(IUnitOfWork unitOfWork)
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

    public async Task<Order> BuyProduct(BuyProductViewModel productViewModel)
    {
        _unitOfWork.BeginTransaction();
        var paymentTypeString = char.ToUpper(productViewModel.PaymentType.ToLower()[0]) +
                                productViewModel.PaymentType.Substring(1);
        var paymentType = (PaymentType) Enum.Parse(typeof(PaymentType), paymentTypeString);
        var order = new Order()
        {
            Id = System.Guid.NewGuid().ToString(),
            PaymentType = paymentType,
            OrderStatus = OrderStatus.Processing,
            PaymentStatus = PaymentStatus.Pending,
            ShippingCost = productViewModel.ShippingCost,
            Email = productViewModel.Email,
            Address = productViewModel.Address
        };

        var totalPrice = 0;
        
        productViewModel.Products.ForEach(p =>
        {
            var product = _unitOfWork.ProductRepository.GetProductById(p.ProductId);
            var orderRow = new OrderRow()
            {
                OrderId = order.Id,
                ProductId = p.ProductId,
                Quantity = p.Quantity
            };
            totalPrice += p.Quantity * product.Price;
            _unitOfWork.OrderRowRepository.AddOrderRows(orderRow);
            _unitOfWork.SaveChanges();
        });

        order.TotalPrice = totalPrice;
        _unitOfWork.OrderRepository.AddOrder(order);
        _unitOfWork.SaveChanges();
        
        _unitOfWork.CommitTransaction();

        return order;
    }
}
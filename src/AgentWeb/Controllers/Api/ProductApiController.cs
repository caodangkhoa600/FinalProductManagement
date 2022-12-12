using Database.Entity;
using Microsoft.AspNetCore.Mvc;
using Models.Product;
using Services.ProductServices;

namespace AgentWeb.Controllers.Api;

[Route("api/[controller]")]
public class ProductApiController : ControllerBase
{
     private readonly IProductServices _productServices;
    
     public ProductApiController(IProductServices productServices)
     {
         _productServices = productServices;
     }
    
     [HttpPost("[action]")]
     public async Task<Order> BuyProduct(BuyProductViewModel viewModel)
     {
         return await _productServices.BuyProduct(viewModel);
     }

     [HttpGet("[action]")]
     public async Task<List<Product>> GetProducts()
     {
         return _productServices.GetAllProducts().ToList();
     }
}
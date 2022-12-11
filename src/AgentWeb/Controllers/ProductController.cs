using Database.Entity;
using Microsoft.AspNetCore.Mvc;
using Models.Product;
using Services.ProductServices;

namespace AgentWeb.Controllers;

[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductServices _productServices;

    public ProductController(IProductServices productServices)
    {
        _productServices = productServices;
    }

    [HttpPost("[action]")]
    public async Task<Order> BuyProduct(BuyProductViewModel viewModel)
    {
        return await _productServices.BuyProduct(viewModel);
    }
}
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.Product;
using Services.CartServices;

namespace AgentWeb.Controllers;

[ApiExplorerSettings(IgnoreApi = true)]
[Authorize]
public class ProductController : Controller
{
    private readonly ICartService _cartService;

    public ProductController(ICartService cartService)
    {
        _cartService = cartService;
    }

    public IActionResult ViewProduct()
    {
        return View();
    }

    public IActionResult BuyProduct()
    {
        if (User.Identity?.Name != null) ViewBag.Email = User.Identity.Name;

        return View();
    }
   
}
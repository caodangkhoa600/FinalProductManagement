using Database.Entity;
using Microsoft.AspNetCore.Mvc;
using Models.Cart;
using Services.CartServices;

namespace AgentWeb.Controllers.Api;

[Route("api/[controller]")]
public class CartApiController : ControllerBase
{
    private readonly ICartService _cartService;

    public CartApiController(ICartService cartService)
    {
        _cartService = cartService;
    }

    [HttpGet("[action]/{email}")]
    public async Task<List<CartViewModel>> GetCarts(string email)
    {
        return _cartService.GetCarts(email);
    }

    [HttpPost("[action]")]
    public async Task<Cart> AddToCart(CartDto cart)
    {
        return _cartService.AddToCart(cart);
    }

    [HttpPut("[action]")]
    public async Task<Cart> UpdateCart(Cart cart)
    {
        return _cartService.UpdateCart(cart);
    }

    [HttpDelete("[action]/{id}")]
    public async Task<Cart?> RemoveCart(int id)
    {
        return _cartService.DeleteCart(id);
    }
}
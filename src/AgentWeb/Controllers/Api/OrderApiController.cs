using Microsoft.AspNetCore.Mvc;
using Models.Order;
using Services.OrderServices;

namespace AgentWeb.Controllers.Api;

[Route("api/[controller]")]
public class OrderApiController : ControllerBase
{
    private readonly IOrderService _orderService;

    public OrderApiController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpGet("[action]")]
    public async Task<List<OrderDto>> GetAllOrders()
    {
        var email = User.Identity.Name;
        return _orderService.GetAllOrderByEmail(email);
    }
    
}
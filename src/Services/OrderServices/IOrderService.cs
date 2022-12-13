using Database.Entity;
using Models.Order;

namespace Services.OrderServices;

public interface IOrderService
{
    IQueryable<Order> GetAllOrders();
    Order? GetOrderByCode(string code);
    List<OrderDto> GetAllOrderByEmail(string email);
    Order UpdateOrder(Order order);
}
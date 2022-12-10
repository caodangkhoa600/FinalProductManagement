using Database.Entity;

namespace Services.OrderServices;

public interface IOrderService
{
    IQueryable<Order> GetAllOrders();
    Order? GetOrderByCode(string code);
    Order UpdateOrder(Order order);
}
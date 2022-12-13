using Database.Entity;
using Models.Order;
using Repositories.RepositoryRoot;

namespace Repositories.OrderRepositories;

public interface IOrderRepository : IRepository<Order, string>
{
    IQueryable<Order> GetAllOrders();
    Order? GetOrderByCode(string code);
    List<OrderDto> GetOrderByEmail(string email);
    Order AddOrder(Order order);
    Order RemoveOrder(Order order);
    Order UpdateOrder(Order order);
}
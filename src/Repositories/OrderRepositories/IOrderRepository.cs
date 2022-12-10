using Database.Entity;
using Repositories.RepositoryRoot;

namespace Repositories.OrderRepositories;

public interface IOrderRepository : IRepository<Order, string>
{
    IQueryable<Order> GetAllOrders();
    Order? GetOrderByCode(string code);
    Order AddOrder(Order order);
    Order RemoveOrder(Order order);
    Order UpdateOrder(Order order);
}
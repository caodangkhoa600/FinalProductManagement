using Database;
using Database.Entity;
using Repositories.RepositoryRoot;

namespace Repositories.OrderRepositories;

public class OrderRepository : Repository<Order, string>, IOrderRepository
{
    public OrderRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public IQueryable<Order> GetAllOrders()
    {
        return GetAll();
    }

    public Order? GetOrderByCode(string code)
    {
        var order = GetAll().FirstOrDefault(e => e.Id == code);
        return order;
    }

    public Order AddOrder(Order order)
    {
        Add(order);
        return order;
    }

    public Order RemoveOrder(Order order)
    {
        Delete(order);
        return order;
    }

    public Order UpdateOrder(Order order)
    {
        Update(order);
        return order;
    }
}
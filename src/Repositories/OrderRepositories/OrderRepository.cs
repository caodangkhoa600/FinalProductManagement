using Database;
using Database.Entity;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models.Order;
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

    public List<OrderDto> GetOrderByEmail(string email)
    {
        var orders = GetAllOrders().Where(e => e.Email == email);
        var result = new List<OrderDto>();
        var paymentTypeConverter = new EnumToStringConverter<PaymentType>();
        orders.ToList().ForEach(e =>
        {
            result.Add(new OrderDto()
            {
                PaymentType = ((PaymentType) e.PaymentType).ToString(),
                PaymentStatus = ((PaymentStatus) e.PaymentStatus).ToString(),
                OrderStatus = ((OrderStatus) e.OrderStatus).ToString(),
                Address = e.Address,
                Email = e.Address,
                TotalPrice = e.TotalPrice,
            });
        });

        return result;
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
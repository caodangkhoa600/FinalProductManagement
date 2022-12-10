using Database.Entity;

namespace Services.OrderRowServices;

public interface IOrderRowService
{
    IQueryable<OrderRow> GetAllOrderRows();
}
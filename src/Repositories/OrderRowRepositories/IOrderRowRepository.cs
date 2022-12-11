using Database.Entity;
using Repositories.RepositoryRoot;

namespace Repositories.OrderRowRepositories;

public interface IOrderRowRepository : IRepository<OrderRow, int>
{
    IQueryable<OrderRow> GetAllOrderRows();
    OrderRow AddOrderRows(OrderRow orderRow);
}
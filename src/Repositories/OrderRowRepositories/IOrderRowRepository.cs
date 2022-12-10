using Database.Entity;
using Repositories.RepositoryRoot;

namespace Repository.OrderRowRepositories;

public interface IOrderRowRepository : IRepository<OrderRow, int>
{
    IQueryable<OrderRow> GetAllOrderRows();
    OrderRow AddOrderRows(OrderRow orderRow);
}
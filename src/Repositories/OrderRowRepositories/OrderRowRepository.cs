using Database;
using Database.Entity;
using Repositories.RepositoryRoot;
using Repository.OrderRowRepositories;

namespace Repositories.OrderRowRepositories;

public class OrderRowRepository : Repository<OrderRow, int>, IOrderRowRepository
{
    public OrderRowRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public IQueryable<OrderRow> GetAllOrderRows()
    {
        return GetAll();
    }

    public OrderRow AddOrderRows(OrderRow orderRow)
    {
        Add(orderRow);
        return orderRow;
    }
}
using Database.Entity;
using UnitOfWork;

namespace Services.OrderRowServices;

public class OrderRowService : IOrderRowService
{
    private readonly IUnitOfWork _unitOfWork;
    public OrderRowService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public IQueryable<OrderRow> GetAllOrderRows()
    {
        return _unitOfWork.OrderRowRepository.GetAllOrderRows();
    }
}
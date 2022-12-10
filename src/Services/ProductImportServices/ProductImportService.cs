using Database.Entity;
using UnitOfWork;

namespace Services.ProductImportServices;

public class ProductImportService : IProductImportService
{
    private readonly IUnitOfWork _unitOfWork;
    
    public ProductImportService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public IQueryable<ProductImportRecord> GetAllProductImports()
    {
        return _unitOfWork.ProductImportRepository.GetAllProductImports();
    }
}
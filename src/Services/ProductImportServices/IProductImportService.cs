
using Database.Entity;

namespace Services.ProductImportServices;

public interface IProductImportService
{
    IQueryable<ProductImportRecord> GetAllProductImports();
}
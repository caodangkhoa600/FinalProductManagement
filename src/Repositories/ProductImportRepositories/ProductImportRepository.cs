using Database;
using Database.Entity;
using Repositories.RepositoryRoot;

namespace Repositories.ProductImportRepositories;

public class ProductImportRepository : Repository<ProductImportRecord, int>, IProductImportRepository
{
    public ProductImportRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public IQueryable<ProductImportRecord> GetAllProductImports()
    {
        return GetAll();
    }

    public ProductImportRecord AddProductImport(ProductImportRecord productImportRecord)
    {
        Add(productImportRecord);
        return productImportRecord;
    }
}
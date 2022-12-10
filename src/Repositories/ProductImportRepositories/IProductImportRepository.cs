using Database.Entity;
using Repositories.RepositoryRoot;

namespace Repositories.ProductImportRepositories;

public interface IProductImportRepository : IRepository<ProductImportRecord, int>
{
    IQueryable<ProductImportRecord> GetAllProductImports();
    ProductImportRecord AddProductImport(ProductImportRecord productImportRecord);
}
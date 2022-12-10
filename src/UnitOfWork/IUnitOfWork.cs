using System.Data;
using Repositories.AccountRepositories;
using Repositories.OrderRepositories;
using Repositories.ProductImportRepositories;
using Repositories.ProductRepositories;
using Repository.OrderRowRepositories;

namespace UnitOfWork;

public interface IUnitOfWork
{
    IAccountRepository AccountRepository { get; set; }
    IOrderRepository OrderRepository { get; set; }
    IOrderRowRepository OrderRowRepository { get; set; }
    IProductImportRepository ProductImportRepository { get; set; }
    IProductRepository ProductRepository { get; set; }
    int SaveChanges();
    void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.ReadCommitted);
    void CommitTransaction();
}
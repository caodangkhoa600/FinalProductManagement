using System.Data;
using Repositories.AccountRepositories;
using Repositories.CartRepositories;
using Repositories.OrderRepositories;
using Repositories.OrderRowRepositories;
using Repositories.ProductImportRepositories;
using Repositories.ProductRepositories;

namespace UnitOfWork;

public interface IUnitOfWork
{
    IAccountRepository AccountRepository { get; }
    IOrderRepository OrderRepository { get; }
    IOrderRowRepository OrderRowRepository { get; }
    IProductImportRepository ProductImportRepository { get; }
    IProductRepository ProductRepository { get; }
    ICartRepository CartRepository { get; }
    int SaveChanges();
    void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.ReadCommitted);
    void CommitTransaction();
}
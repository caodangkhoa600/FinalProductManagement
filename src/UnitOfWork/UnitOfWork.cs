using System.Data;
using Database;
using Repositories.AccountRepositories;
using Repositories.CartRepositories;
using Repositories.OrderRepositories;
using Repositories.OrderRowRepositories;
using Repositories.ProductImportRepositories;
using Repositories.ProductRepositories;

namespace UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _dbContext;
    
    public IAccountRepository AccountRepository { get; }
    public IOrderRepository OrderRepository { get; }
    public IOrderRowRepository OrderRowRepository { get; }
    public IProductImportRepository ProductImportRepository { get; }
    public IProductRepository ProductRepository { get; }
    public ICartRepository CartRepository { get; }

    public UnitOfWork(
        ApplicationDbContext dbContext, 
        IAccountRepository accountRepository,
        IOrderRepository orderRepository, 
        IOrderRowRepository orderRowRepository,
        IProductImportRepository productImportRepository, 
        IProductRepository productRepository, ICartRepository cartRepository)
    {
        _dbContext = dbContext;
        AccountRepository = accountRepository;
        OrderRepository = orderRepository;
        OrderRowRepository = orderRowRepository;
        ProductImportRepository = productImportRepository;
        ProductRepository = productRepository;
        CartRepository = cartRepository;
    }

    public int SaveChanges()
    {
        return _dbContext.SaveChanges();
    }

    public void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.ReadCommitted)
    {
        _dbContext.Database.BeginTransaction();
    }

    public void CommitTransaction()
    {
        _dbContext.Database.CommitTransaction();
    }
}
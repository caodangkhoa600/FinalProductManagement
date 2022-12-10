using System.Data;
using Database;
using Repositories.AccountRepositories;
using Repositories.OrderRepositories;
using Repositories.ProductImportRepositories;
using Repositories.ProductRepositories;
using Repository.OrderRowRepositories;

namespace UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _dbContext;
    
    public IAccountRepository AccountRepository { get; set; }
    public IOrderRepository OrderRepository { get; set; }
    public IOrderRowRepository OrderRowRepository { get; set; }
    public IProductImportRepository ProductImportRepository { get; set; }
    public IProductRepository ProductRepository { get; set; }

    public UnitOfWork(
        ApplicationDbContext dbContext, 
        IAccountRepository accountRepository,
        IOrderRepository orderRepository, 
        IOrderRowRepository orderRowRepository,
        IProductImportRepository productImportRepository, 
        IProductRepository productRepository
        )
    {
        _dbContext = dbContext;
        AccountRepository = accountRepository;
        OrderRepository = orderRepository;
        OrderRowRepository = orderRowRepository;
        ProductImportRepository = productImportRepository;
        ProductRepository = productRepository;
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
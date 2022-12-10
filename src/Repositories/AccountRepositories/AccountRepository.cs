using Database;
using Database.Entity;
using Repositories.RepositoryRoot;

namespace Repositories.AccountRepositories;

public class AccountRepository : Repository<Account, int>, IAccountRepository 
{
    public AccountRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public IQueryable<Account> GetAllAccounts()
    {
        var accounts = GetAll();
        return accounts;
    }

    public Account? GetAccountByUserName(string username)
    {
        var account = GetAll().FirstOrDefault(e => e.Username == username);
        return account;
    }

    public Account AddAccount(Account account)
    {
        Add(account);
        return account;
    }
}
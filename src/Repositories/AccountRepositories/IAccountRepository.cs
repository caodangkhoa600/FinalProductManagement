using Database.Entity;
using Repositories.RepositoryRoot;

namespace Repositories.AccountRepositories;

public interface IAccountRepository : IRepository<Account, int>
{
    IQueryable<Account> GetAllAccounts();
    Account? GetAccountByUserName(string username);
    Account AddAccount(Account account);
}
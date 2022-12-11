using Database.Entity;

namespace Services.AccountService;

public interface IAccountServices
{
    ICollection<Account> GetAllAccounts();
    Account? GetAccountByUserName(string username);
}
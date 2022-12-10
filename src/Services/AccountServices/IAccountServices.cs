using Database.Entity;

namespace Services.AccountServices;

public interface IAccountServices
{
    ICollection<Account> GetAllAccounts();
    Account? GetAccountByUserName(string username);
}
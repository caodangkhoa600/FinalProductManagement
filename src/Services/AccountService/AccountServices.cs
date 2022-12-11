using Database.Entity;
using UnitOfWork;

namespace Services.AccountService;

public class AccountServices : IAccountServices
{
    private readonly IUnitOfWork _unitOfWork;
    
    public AccountServices(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public ICollection<Account> GetAllAccounts()
    {
        var accounts = _unitOfWork.AccountRepository.GetAll().ToList();
        return accounts;
    }

    public Account? GetAccountByUserName(string username)
    {
        _unitOfWork.BeginTransaction();
        var account = _unitOfWork.AccountRepository.GetAccountByUserName(username);
        _unitOfWork.CommitTransaction();
        return account;
    }
}
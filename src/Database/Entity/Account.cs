using Database.Entity.Root;

namespace Database.Entity;

public class Account : AggressiveRoot<int>
{
    public string Username { get; set; }
    public string Address { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public AccountType Type { get; set; }
}

public enum AccountType
{
    Agent = 1,
    Customer = 2,
    Admin = 3
}
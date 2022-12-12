using Database.Entity.Root;

namespace Database.Entity;

public class Cart : AggressiveRoot<int>
{
    public string ProductId { get; set; }
    public string? Email { get; set; }
    public int Quantity { get; set; }
}
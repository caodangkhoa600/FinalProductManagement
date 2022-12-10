
using Database.Entity.Root;

namespace Database.Entity;

public class OrderRow : AggressiveRoot<int>
{
    public string OrderId { get; set; }
    public string ProductId { get; set; }
    public int Quantity { get; set; }
}
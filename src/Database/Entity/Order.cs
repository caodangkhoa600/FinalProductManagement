
using Database.Entity.Root;

namespace Database.Entity;

public class Order : AggressiveRoot<string>
{
    public PaymentType PaymentType { get; set; } 
    public PaymentStatus PaymentStatus { get; set; }
    public OrderStatus OrderStatus { get; set; }
    public int TotalPrice { get; set; }
    public string Email { get; set; }
    public int ShippingCost { get; set; }
    public string Address { get; set; }
}

public enum PaymentType
{
    Bank = 1,
    Cash = 2,
    Momo = 3
}

public enum PaymentStatus
{
    Paid = 1,
    Pending = 2
}

public enum OrderStatus
{
    Processing = 1,
    Delivering = 2,
    Delivered = 3
}
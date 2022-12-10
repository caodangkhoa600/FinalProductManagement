public class CustomerOrderFullModel
{
    public string OrderId { get; set; }
    public string Email { get; set; }
    public string FullName { get; set; }
    public string Address { get; set; }
    public string PaymentType { get; set; }
    public string PaymentStatus { get; set; }
    public string OrderStatus { get; set; }
    public int TotalPrice { get; set; }
    public DateTime CreatedAt { get; set; }
}
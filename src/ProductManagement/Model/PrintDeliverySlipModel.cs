namespace ProductManagement.Model;

public class PrintDeliverySlipModel
{
    public string Email { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public DateTime CreatedAt { get; set; }
    public int TotalPrice { get; set; }
    public string OrderId { get; set; }
}
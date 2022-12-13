using System.Text.Json.Serialization;

namespace Models.Order;

public class OrderDto
{
    [JsonPropertyName("payment_type")]
    public string PaymentType { get; set; }
    [JsonPropertyName("payment_status")]
    public string PaymentStatus { get; set; }
    [JsonPropertyName("order_status")]
    public string OrderStatus { get; set; }
    [JsonPropertyName("total_price")]
    public int TotalPrice { get; set; }
    [JsonPropertyName("email")]
    public string Email { get; set; }
    [JsonPropertyName("address")]
    public string Address { get; set; }
}
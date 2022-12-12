using System.Text.Json.Serialization;

namespace Models.Product;

public class BuyProductViewModel
{
    [JsonPropertyName("email")]
    public string Email { get; set; }
    [JsonPropertyName("payment_type")]
    public string PaymentType { get; set; }
    [JsonPropertyName("products")]
    public List<BuyProductModel> Products { get; set; }
    [JsonPropertyName("shipping_cost")]
    public int ShippingCost { get; set; }
    [JsonPropertyName("address")]
    public string Address { get; set; }
}
using System.Text.Json.Serialization;

namespace Models.Product;

public class BuyProductModel
{
    [JsonPropertyName("product_id")]
    public string ProductId { get; set; }
    [JsonPropertyName("quantity")]
    public int Quantity { get; set; }
}
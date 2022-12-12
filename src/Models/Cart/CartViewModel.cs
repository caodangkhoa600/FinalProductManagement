using System.Text.Json.Serialization;

namespace Models.Cart;

public class CartViewModel
{
    [JsonPropertyName("product_id")]
    public string ProductId { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("quantity")]
    public int Quantity { get; set; }
    [JsonPropertyName("total_price")]
    public int TotalPrice { get; set; }
}
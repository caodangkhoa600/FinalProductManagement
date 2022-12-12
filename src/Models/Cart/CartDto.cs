using System.Text.Json.Serialization;

namespace Models.Cart;

public class CartDto
{
    [JsonPropertyName("product_id")]
    public string ProductId { get; set; }
    [JsonPropertyName("email")]
    public string? Email { get; set; }
    [JsonPropertyName("quantity")]
    public int Quantity { get; set; }
    
}
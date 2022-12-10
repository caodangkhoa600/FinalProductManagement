
using Database.Entity.Root;

namespace Database.Entity;

public class Product : AggressiveRoot<string>
{
    public string Name { get; set; }
    public int Quantity { get; set; }
    public int Price { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
}
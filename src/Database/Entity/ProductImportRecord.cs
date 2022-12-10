
using Database.Entity.Root;

namespace Database.Entity;

public class ProductImportRecord : AggressiveRoot<int>
{
    public string ProductId { get; set; }
    public int Quantity { get; set; }
}
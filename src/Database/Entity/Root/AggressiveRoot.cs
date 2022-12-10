namespace Database.Entity.Root;

public class AggressiveRoot<T>
{
    public T Id { get; set; }
    public long? CreatedAt { get; set; }
    public long? UpdatedAt { get; set; }
}
using Database;
using Database.Entity;
using Repositories.RepositoryRoot;

namespace Repositories.CartRepositories;

public class CartRepository : Repository<Cart, int>, ICartRepository
{
    public CartRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public IQueryable<Cart> GetAllCarts()
    {
        return GetAll(); 
    }

    public Cart AddCart(Cart cart)
    {
        Add(cart);
        return cart;
    }

    public Cart UpdateCart(Cart cart)
    {
        Update(cart);
        return cart;
    }

    public Cart DeleteCart(int id)
    {
        var cart = GetCartById(id);
        Delete(cart!);
        return cart!;
    }

    public Cart? GetCartById(int id)
    {
        var cart = GetAll().FirstOrDefault(c => c.Id == id);
        return cart;
    }
}
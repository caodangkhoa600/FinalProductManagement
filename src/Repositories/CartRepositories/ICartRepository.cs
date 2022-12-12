using Database.Entity;
using Repositories.RepositoryRoot;

namespace Repositories.CartRepositories;

public interface ICartRepository : IRepository<Cart, int>
{
    IQueryable<Cart> GetAllCarts();
    Cart AddCart(Cart cart);
    Cart UpdateCart(Cart cart);
    Cart DeleteCart(int id);
    Cart? GetCartById(int id);
}
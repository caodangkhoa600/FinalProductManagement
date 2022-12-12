using Database.Entity;
using Models.Cart;

namespace Services.CartServices;

public interface ICartService
{
    List<CartViewModel> GetCarts(string email);
    Cart AddToCart(CartDto cart);
    Cart UpdateCart(Cart cart);
    Cart? DeleteCart(int id);
}
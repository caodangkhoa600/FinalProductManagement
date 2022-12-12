using Database.Entity;
using Models.Cart;
using UnitOfWork;

namespace Services.CartServices;

public class CartService : ICartService
{
    private readonly IUnitOfWork _unitOfWork;

    public CartService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public List<CartViewModel> GetCarts(string email)
    {
        var carts = _unitOfWork.CartRepository.GetAllCarts().Where(e => e.Email == email);
        var cartDtos = new List<CartViewModel>();
        var products = _unitOfWork.ProductRepository.GetAllProducts();
        carts.ToList().ForEach(c =>
        {
            var product = products.First(e => e.Id == c.ProductId);
            cartDtos.Add(new CartViewModel()
            {
                ProductId = c.ProductId,
                Name = product.Name,
                Quantity = c.Quantity,
                TotalPrice = product.Price * c.Quantity
            });
        });

        return cartDtos;
    }

    public Cart AddToCart(CartDto cart)
    {
        var cartEntity = _unitOfWork.CartRepository.GetAll().FirstOrDefault(e => e.Email == cart.Email && e.ProductId == cart.ProductId);
        if (cartEntity == null)
        {
            var newCart = new Cart
            {
                ProductId = cart.ProductId,
                Email = cart.Email,
                Quantity = cart.Quantity
            };
            _unitOfWork.CartRepository.AddCart(newCart);
            _unitOfWork.SaveChanges();
            cartEntity = newCart;
        }
        else
        {
            cartEntity.Quantity += cart.Quantity;
            _unitOfWork.CartRepository.UpdateCart(cartEntity);
            _unitOfWork.SaveChanges();
        }

        return cartEntity;
    }

    public Cart UpdateCart(Cart cart)
    {
        _unitOfWork.CartRepository.UpdateCart(cart);
        _unitOfWork.SaveChanges();
        return cart;
    }

    public Cart? DeleteCart(int id)
    {
        var cart = _unitOfWork.CartRepository.GetCartById(id);
        _unitOfWork.CartRepository.DeleteCart(id);
        _unitOfWork.SaveChanges();
        return cart;
    }
}
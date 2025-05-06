using CarService.Entities;

namespace CarService.DataAccess.Abstract
{
    public interface ICartService
    {
        void AddCart(List<CartDetail> details);
        Task<Cart> GetCart(int id);
        Task<Cart> AddCartName(Cart cart);
        Task<List<Cart>> GetCartList();
    }
}

using CarService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

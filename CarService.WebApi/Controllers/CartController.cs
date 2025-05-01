using CarService.DataAccess;
using CarService.Entities;
using Microsoft.AspNetCore.Mvc;
using CarService.DataAccess.Abstract;
using CarService.Entities.Dto_s;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarService.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartController;

        private readonly AppDataContext _appDataContext;

        public CartController(ICartService cartController, AppDataContext appDataContext)
        {
            _cartController = cartController;
            _appDataContext = appDataContext;
        }

        [HttpPost]
        public void AddCart([FromBody] BuyCartDto BuyCart)
        {
            var cart = _cartController.AddCartName(BuyCart.Cart);

            foreach(CartDetail i in BuyCart.CartDetails)
            {
                i.CartId = cart.Id;
            }

            _cartController.AddCart(BuyCart.CartDetails);

            _appDataContext.SaveChanges();
        }

        [HttpGet]
        public void GetCart(int id)
        {
            _cartController?.GetCart(id);
        }
    }
}

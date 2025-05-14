using CarService.DataAccess;
using CarService.Entities;
using Microsoft.AspNetCore.Mvc;
using CarService.DataAccess.Abstract;
using CarService.Entities.Dto_s;
using System.Threading.Tasks;

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

        [HttpPost("AddCart")]
        public async Task<ActionResult> AddCart([FromBody] BuyCartDto buycart)
        {
            var cartAdd = await _cartController.AddCartName(buycart.Cart);

            cartAdd.Time = DateTime.Now;

            await _cartController.DecreaseDetailCount(buycart.Cart.Details, cartAdd.Id);

            await _cartController.EditCartDetails(cartAdd.Id, buycart.Cart.Details);

            return Ok();
        }

        [HttpGet("GetCart")]
        public Task<Cart> GetCart(int id)
        {
            return _cartController.GetCart(id);
        }
    }
}

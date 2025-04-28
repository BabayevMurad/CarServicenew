using CarService.DataAccess.Abstract;
using CarService.Entities;
using Microsoft.EntityFrameworkCore;


namespace CarService.DataAccess.Concrete
{
    public class CartService : ICartService
    {
        private readonly IAppRepository _appRepository;

        private readonly AppDataContext _context;

        public CartService(IAppRepository appRepository, AppDataContext context)
        {
            _appRepository = appRepository;
            _context = context;
        }

        public async void AddCart(List<CartDetail> details)
        {
            foreach (var item in details)
            {
                await _appRepository.AddAsync(details);
            }

            _context.SaveChanges();
        }

        public async Task<Cart> AddCartName(Cart cart)
        {
            var cartReturn = await _appRepository.AddCartAsync(cart);

            _context.SaveChanges();

            return cartReturn;
        }

        public Task<List<Cart>> GetCartList()
        {
            var cart = _context.Cart
                .Include(d => d.Details)
                .ToListAsync();

            return cart;
        }

        public Task<Cart> GetCart(int id)
        {
            var cart = _context.Cart
                .Include(d => d.Details)
                .FirstOrDefaultAsync(c => c.Id == id);

            #pragma warning disable CS8619
            return cart;
            #pragma warning restore CS8619
        }
    }
}

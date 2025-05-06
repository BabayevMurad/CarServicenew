namespace CarService.Entities.Dto_s
{
    public class BuyCartDto
    {
        #pragma warning disable CS8618
        public Cart Cart { get; set; }
        public List<CartDetail> CartDetails { get; set; }
        #pragma warning restore CS8618
    }
}

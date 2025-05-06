namespace CarService.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public virtual List<CartDetail>? Details { get; set; }
    }
}

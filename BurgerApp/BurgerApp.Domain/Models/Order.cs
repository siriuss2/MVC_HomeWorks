namespace BurgerApp.Domain.Models
{
    public class Order : BaseEntity
    {
        public string FullName { get; set; } = string.Empty;
        public string Address { get; set; }
        public bool IsDelivered { get; set; }
        public List<Burger> Burgers { get; set; } = new List<Burger>();
        public Location Location { get; set; }
        public int LocationId { get; set; }
        public List<OrderBurger> OrderBurger { get; set; } = new List<OrderBurger>();

    }
}

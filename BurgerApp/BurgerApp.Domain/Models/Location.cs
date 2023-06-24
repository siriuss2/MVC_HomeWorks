namespace BurgerApp.Domain.Models
{
    public class Location : BaseEntity
    {
        public Location(string name , string address , string opensAt , string closesAt)
        {
            Name = name;
            Address = address;
            OpensAt = opensAt;
            ClosesAt = closesAt;
        }
        public Location()
        {
            
        }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string OpensAt { get; set; } 
        public string ClosesAt { get; set; }
        public List<Order> Orders { get; set; }
    }
}

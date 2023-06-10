namespace Class02_Homework.Models
{
    public class Order
    {
        public Order()
        {
            
        }

        public Order(string name , string address , string city)
        {
            Name = name;
            Address = address;
            City = city;
        }
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;

    }
}

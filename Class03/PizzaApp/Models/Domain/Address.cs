namespace PizzaApp.Models.Domain
{
    public class Address
    {
        public Address(string street, string city,int number)
        {
            Street = street;
            City = city;
            Number = number;
        }
        public string Street { get; set; }
        public int Number { get; set; }
        public string City { get; set; }

    }

}

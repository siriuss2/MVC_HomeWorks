using Class02_Homework.Models;

namespace Class02_Homework
{
    public static class StaticDb
    {
        public static List<Order> Orders = new List<Order>()
        {
            new Order()
            {
                Id = 1,
                Name = "Antonio",
                Address = "Partizanska 10",
                City = "Skopje"
            },
            new Order()
            {
                Id = 2,
                Name = "Kostadin",
                Address = "Mladinska 5",
                City = "Skopje"
            },
            new Order()
            {
                Id = 3,
                Name = "Bojan",
                Address = "Bojanovska Ulica 1",
                City = "Bitola"
            }
        };
    }
}

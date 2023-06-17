using PizzaApp.Models.Domain;
using PizzaApp.Models.Enums;

namespace PizzaApp
{
    public static class StaticDb
    {
        public static int UserId = 2;
        public static List<Pizza> Pizzas = new List<Pizza>()
        {
            new Pizza()
            {
                Id = 1,
                Name = "Capri",
                Price = 300,
                IsOnPromotion = true,
                ImageUrl = @"https://hips.hearstapps.com/hmg-prod/images/classic-cheese-pizza-recipe-2-64429a0cb408b.jpg?crop=0.6666666666666667xw:1xh;center,top&resize=1200:*",
                Ingredients = new List<string>()
                {
                    "Salami Pork/Chicken",
                    "Cheese / Mocarella",
                    "Mushrooms",
                    "Ketchup",
                    "Basil"
                },
                PizzaSize = new List<PizzaSize>()
                {
                    PizzaSize.Normal,
                    PizzaSize.Family
                },

                HasExtras = true

            },
            new Pizza()
            {
                Id = 2,
                Name = "Pepperoni",
                Price = 400,
                IsOnPromotion = false,
                ImageUrl = @"https://hips.hearstapps.com/hmg-prod/images/classic-cheese-pizza-recipe-2-64429a0cb408b.jpg?crop=0.6666666666666667xw:1xh;center,top&resize=1200:*",
                Ingredients = new List<string>()
                {
                    "Pepperoni",
                    "Cheese / Mocarella",
                    "Mushrooms",
                    "Ketchup",
                    "Basil"
                },
                PizzaSize = new List<PizzaSize>()
                {
                    PizzaSize.Normal,
                    PizzaSize.Family
                },
                HasExtras = true

            },
            new Pizza()
            {
                Id = 3,
                Name = "Mexicana",
                Price = 500,
                IsOnPromotion = true,
                ImageUrl = @"https://hips.hearstapps.com/hmg-prod/images/classic-cheese-pizza-recipe-2-64429a0cb408b.jpg?crop=0.6666666666666667xw:1xh;center,top&resize=1200:*",
                Ingredients = new List<string>()
                {
                    "Pepperoni",
                    "Cheese / Mocarella",
                    "Kulen",
                    "Ketchup",
                    "Bacon"
                },
                PizzaSize = new List<PizzaSize>()
                {
                    PizzaSize.Normal,
                    PizzaSize.Family
                },

                HasExtras = false

            }
        };
        public static List<User> Users = new List<User>()
        {
            new User()
            {
                Id = 1,
                FirstName = "Antonio",
                LastName = "Novoselski",
                PhoneNumber = "078417501",
                Address = new Address("Mladinska" , "Skopje" , 10)
            },
            new User()
            {
                Id = 2,
                FirstName = "Kate",
                LastName = "Kateski",
                PhoneNumber = "078241294",
                Address = new Address("Partizanska" , "Skopje" , 15)
            }
        };

        public static List<Order> Orders = new List<Order>()
        {
            new Order()
            {
                Id = 1,
                PizzaId = 1,
                UserId = 2,
                Pizza = Pizzas.First(x => x.Id == 1),
                User = Users.First(x => x.Id == 2),
                PaymentMethod = PaymentMethod.Cash,
                UserAddress = new Address("Partizanska" , "Bitola" , 15)
            },
            new Order()
            {
                Id = 2,
                PizzaId = 2,
                UserId = 2,
                Pizza = Pizzas.First(x => x.Id == 2),
                User = Users.First(x => x.Id == 2),
                PaymentMethod = PaymentMethod.Card,
                UserAddress = new Address("Mladinska" , "Skopje" , 10)
            }
        };
    }
}

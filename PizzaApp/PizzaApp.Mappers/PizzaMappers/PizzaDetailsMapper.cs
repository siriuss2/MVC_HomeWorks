using PizzaApp.Domain.Models;
using PizzaApp.ViewModels.PizzaViewModels;

namespace PizzaApp.Mappers.PizzaMappers
{
    public static class PizzaDetailsMapper
    {
        public static PizzaDetailsViewModel ToPizzaDetailsViewModel(this Pizza pizza)
        {
            return new PizzaDetailsViewModel
            {
                Name = pizza.Name,
                IsOnPromotion = pizza.IsOnPromotion
            };
        }
    }
}

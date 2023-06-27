using PizzaApp.ViewModels.PizzaViewModels;

namespace PizzaApp.Services.Interfaces
{
    public interface IPizzaService
    {
        Task<List<PizzaListViewModel>> GetPizzasForCards();

    }
}

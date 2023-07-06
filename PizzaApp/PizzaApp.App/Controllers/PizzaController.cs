using Microsoft.AspNetCore.Mvc;
using PizzaApp.DataAccess.DataContext;
using PizzaApp.DataAccess.Repositories.Interfaces;
using PizzaApp.Domain.Models;
using PizzaApp.Services.Interfaces;
using PizzaApp.ViewModels.PizzaViewModels;

namespace PizzaApp.App.Controllers
{
    public class PizzaController : Controller
    {
        private IPizzaService _pizzaService;
        public PizzaController(IPizzaService _pizzaService , IRepository<Pizza> _pizzaDb)
        {
            this._pizzaService = _pizzaService;
        }
        public async Task<IActionResult> IndexAsync()
        {
            return View(await _pizzaService.GetPizzasForCards());
        }

    }
}

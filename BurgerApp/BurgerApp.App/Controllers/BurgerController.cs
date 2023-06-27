using BurgerApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BurgerApp.App.Controllers
{
    public class BurgerController : Controller
    {
        private IBurgerService _burgerService;

        public BurgerController(IBurgerService _burgerService)
        {
            this._burgerService = _burgerService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _burgerService.GetBurgersForCards());
        }
    }
}

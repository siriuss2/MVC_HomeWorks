using Microsoft.AspNetCore.Mvc;

namespace BurgerApp.App.Controllers
{
    public class BurgerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

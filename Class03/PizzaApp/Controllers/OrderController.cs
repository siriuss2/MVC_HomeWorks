using Microsoft.AspNetCore.Mvc;
using PizzaApp.Models.Domain;
using PizzaApp.Models.Mappers;
using PizzaApp.Models.ViewModels.OrderViewModels;

namespace PizzaApp.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int? id)
        {
            if(id == null)
                RedirectToAction("Error", "Home");


            Order orderDb = StaticDb.Orders.FirstOrDefault(o => o.Id == id);

            if(orderDb == null)
                RedirectToAction("Error" , "Home");


            OrderDetailsViewModel orderDetails = orderDb.MapFromOrderToOrderDetailsViewModel();
            return View(orderDetails);
        }
    }
}

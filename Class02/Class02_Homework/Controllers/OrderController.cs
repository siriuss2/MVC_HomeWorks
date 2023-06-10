using Class02_Homework.Models;
using Microsoft.AspNetCore.Mvc;

namespace Class02_Homework.Controllers
{
    public class OrderController : Controller
    {
        [Route("ListOrders")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult JsonData()
        {
            Order order = new Order()
            {
                Id = 1,
                Name = "Joe",
                Address = "Joe Doe 10",
                City = "London"
            };
            return new JsonResult(order);
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                // Checks if the URL contains only "/order/details" , if it is true it will display all of the orders
                if (HttpContext.Request.Path.Value.Equals("/order/details", StringComparison.OrdinalIgnoreCase))
                    return View("DisplayAllOrders", StaticDb.Orders);
                else
                    // If it's not true , it will display the error message from Home Contoller
                    return RedirectToAction("Error", "Home");
            }

            Order order = StaticDb.Orders.FirstOrDefault(x => x.Id == id);

            if (order == null)
                return new EmptyResult();

            return View(order);
        }


        public IActionResult Redirect()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}

using BurgerApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BurgerApp.App.Controllers
{
    public class OrderController : Controller
    {
        private IOrderService _orderService;

        public OrderController(IOrderService _orderService)
        {
            this._orderService = _orderService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _orderService.GetAllOrders());
        }
    }
}

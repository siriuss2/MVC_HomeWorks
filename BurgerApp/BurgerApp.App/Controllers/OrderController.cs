using BurgerApp.Services.Interfaces;
using BurgerApp.ViewModels.OrderViewModels;
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

        public async Task<IActionResult> Delete(int id)
        {
            return View(await _orderService.DeleteOrderById(id));
        }

        public IActionResult Create()
        {
            OrderViewModel orderViewModel = new OrderViewModel();
            return View(orderViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(OrderViewModel orderViewModel)
        {
            await _orderService.CreateOrder(orderViewModel);
            return RedirectToAction("Index");
        }
    }
}

using BurgerApp.Services.Interfaces;
using BurgerApp.ViewModels.OrderViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BurgerApp.App.Controllers
{
    public class OrderController : Controller
    {
        private IOrderService _orderService;
        private ILocationService _locationService;

        public OrderController(IOrderService _orderService, ILocationService _locationService)
        {
            this._orderService = _orderService;
            this._locationService = _locationService;

        }
        public async Task<IActionResult> Index()
        {
            return View(await _orderService.GetAllOrders());
        }

        public async Task<IActionResult> Delete(int id)
        {
            return View(await _orderService.DeleteOrderById(id));
        }

        public async Task<IActionResult> Create()
        {
            OrderViewModel orderViewModel = new OrderViewModel();
            ViewBag.Locations = await _locationService.GetLocationsForDropdown();

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

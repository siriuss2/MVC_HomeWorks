using BurgerApp.Domain.Models;
using BurgerApp.ViewModels.OrderViewModels;

namespace BurgerApp.Services.Interfaces
{
    public interface IOrderService
    {
        Task<List<OrderListViewModel>> GetAllOrders();
    }
}

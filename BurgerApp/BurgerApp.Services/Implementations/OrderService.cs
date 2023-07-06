using BurgerApp.DataAccess.Repositories.Interfaces;
using BurgerApp.Domain.Models;
using BurgerApp.Mappers.OrderMappers;
using BurgerApp.Services.Interfaces;
using BurgerApp.ViewModels.OrderViewModels;

namespace BurgerApp.Services.Implementations
{
    public class OrderService : IOrderService
    {
        private IRepository<Order> _orderRepository;

        public OrderService(IRepository<Order> _orderRepository)
        {
            this._orderRepository = _orderRepository;
        }

        public Task CreateOrder(OrderViewModel orderViewModel)
        {
            return _orderRepository.Insert(orderViewModel.ToOrder());
        }

        public async Task<int> DeleteOrderById(int id)
        {
            return await _orderRepository.DeleteById(id);
        }

        public async Task<List<OrderListViewModel>> GetAllOrders()
        {
            List<Order> orderDb = await _orderRepository.GetAll();
            return orderDb.Select(x => x.ToOrderListViewModel()).ToList();
        }
    }
}

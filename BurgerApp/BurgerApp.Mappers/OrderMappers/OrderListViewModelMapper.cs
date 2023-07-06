﻿using BurgerApp.Domain.Models;
using BurgerApp.ViewModels.OrderViewModels;

namespace BurgerApp.Mappers.OrderMappers
{
    public static class OrderListViewModelMapper
    {
        public static OrderListViewModel ToOrderListViewModel(this Order order)
        {
            return new OrderListViewModel()
            {
                Id = order.Id,
                FullName = order.FullName,
                Address = order.Address,
                IsDelivered = order.IsDelivered
            };
        }

        public static Order ToOrder(this OrderViewModel orderViewModel)
        {
            return new Order
            {
                Id = orderViewModel.Id,
                FullName = orderViewModel.FullName,
                Address = orderViewModel.Address,
                IsDelivered = orderViewModel.IsDelivered
            };
        }
    }
}

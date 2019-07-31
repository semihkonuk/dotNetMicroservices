using dotNetMicroservices.Ordering.Application.Interfaces;
using dotNetMicroservices.Ordering.Domain.Interfaces;
using dotNetMicroservices.Ordering.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotNetMicroservices.Ordering.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public IEnumerable<Order> GetOrders()
        {
            return _orderRepository.GerOrders();
        }
    }
}

using dotNetMicroservices.EventBus.Bus;
using dotNetMicroservices.Ordering.Application.Interfaces;
using dotNetMicroservices.Ordering.Application.Models;
using dotNetMicroservices.Ordering.Domain.Commands;
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
        private readonly IEventBus _eventBus;

        public OrderService(IOrderRepository orderRepository, IEventBus eventBus)
        {
            _orderRepository = orderRepository;
            _eventBus = eventBus;
        }

        public IEnumerable<Order> GetOrders()
        {
            return _orderRepository.GerOrders();
        }

        public void Shipment(Shipment shipment)
        {
            _eventBus.SendCommand(new CreateShipmentCommand(
                shipment.ProductName,
                shipment.Address
                ));
        }
    }
}

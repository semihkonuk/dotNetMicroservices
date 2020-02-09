using dotNetMicroservices.EventBus.Bus;
using dotNetMicroservices.Shipping.Api.Data.Repository;
using dotNetMicroservices.Shipping.Api.Models;
using dotNetMicroservices.Shipping.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetMicroservices.Shipping.Api.EventHandlers
{
    public class ShipmentEventHandler : IEventHandler<ShipmentCreatedEvent>
    {
        private readonly IShippingRepository _shippingRepository;
        public ShipmentEventHandler(IShippingRepository shippingRepository)
        {
            _shippingRepository = shippingRepository;
        }

        public Task Handle(ShipmentCreatedEvent @event)
        {
            _shippingRepository.Add(new Shipment
            {
                Address = @event.Address,
                ProductName = @event.ProductName
            });

            return Task.CompletedTask;
        }
    }
}

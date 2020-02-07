using dotNetMicroservices.EventBus.Bus;
using dotNetMicroservices.Shipping.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetMicroservices.Shipping.Api.EventHandlers
{
    public class ShipmentEventHandler : IEventHandler<ShipmentCreatedEvent>
    {
        public ShipmentEventHandler()
        {
        }

        public Task Handle(ShipmentCreatedEvent @event)
        {
            return Task.CompletedTask;
        }
    }
}

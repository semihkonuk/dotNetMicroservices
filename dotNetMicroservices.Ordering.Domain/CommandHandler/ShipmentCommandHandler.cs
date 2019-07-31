using dotNetMicroservices.EventBus.Bus;
using dotNetMicroservices.Ordering.Domain.Commands;
using dotNetMicroservices.Ordering.Domain.Events;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dotNetMicroservices.Ordering.Domain.CommandHandler
{
    public class ShipmentCommandHandler : IRequestHandler<CreateShipmentCommand, bool>
    {
        private readonly IEventBus _eventBus;
        public ShipmentCommandHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }
        public Task<bool> Handle(CreateShipmentCommand request, CancellationToken cancellationToken)
        {
            _eventBus.Publish(new ShipmentCreatedEvent(request.ProductName, request.Address));
            return Task.FromResult(true);
        }
    }
}

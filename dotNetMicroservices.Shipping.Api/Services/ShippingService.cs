using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotNetMicroservices.EventBus.Bus;
using dotNetMicroservices.Shipping.Api.Data.Repository;
using dotNetMicroservices.Shipping.Api.Models;

namespace dotNetMicroservices.Shipping.Api.Services
{
    public class ShippingService : IShippingService
    {

        private readonly IShippingRepository _shippingRepository;
        private readonly IEventBus _eventBus;

        public ShippingService(IShippingRepository shippingRepository, IEventBus eventBus)
        {
            _shippingRepository = shippingRepository;
            _eventBus = eventBus;
        }

        public IEnumerable<Shipment> GetShipments()
        {
            return _shippingRepository.GetAllShipment();
        }
    }
}

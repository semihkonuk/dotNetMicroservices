using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotNetMicroservices.Shipping.Api.Data.Context;
using dotNetMicroservices.Shipping.Api.Models;

namespace dotNetMicroservices.Shipping.Api.Data.Repository
{
    public class ShippingRepository : IShippingRepository
    {
        private readonly ShippingDbContext _shippingDbContext;

        public ShippingRepository(ShippingDbContext shippingDbContext)
        {
            _shippingDbContext = shippingDbContext;
        }

        public void Add(Shipment shipment)
        {
            _shippingDbContext.Add(shipment);
        }

        public IEnumerable<Shipment> GetAllShipment()
        {
            return _shippingDbContext.Shipments;
        }
    }
}

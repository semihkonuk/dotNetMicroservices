using dotNetMicroservices.Shipping.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetMicroservices.Shipping.Api.Services
{
    public interface IShippingService
    {
        IEnumerable<Shipment> GetShipments();
    }
}

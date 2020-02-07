using dotNetMicroservices.Shipping.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetMicroservices.Shipping.Api.Data.Repository
{
    public interface IShippingRepository
    {
        IEnumerable<Shipment> GetAllShipment();
    }
}

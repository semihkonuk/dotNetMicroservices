using dotNetMicroservices.Ordering.Application.Models;
using dotNetMicroservices.Ordering.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotNetMicroservices.Ordering.Application.Interfaces
{
    public interface IOrderService
    {
        IEnumerable<Order> GetOrders();
        void Shipment(Shipment shipment);
    }
}

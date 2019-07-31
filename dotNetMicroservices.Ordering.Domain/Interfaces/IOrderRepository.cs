using dotNetMicroservices.Ordering.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotNetMicroservices.Ordering.Domain.Interfaces
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GerOrders();
    }
}

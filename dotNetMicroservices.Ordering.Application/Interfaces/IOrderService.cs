using dotNetMicroservices.Ordering.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotNetMicroservices.Ordering.Application.Interfaces
{
    public interface IOrderService
    {
        IEnumerable<Order> GetOrders();
    }
}

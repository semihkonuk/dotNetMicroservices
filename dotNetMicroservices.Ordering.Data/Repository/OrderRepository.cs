using dotNetMicroservices.Ordering.Data.Context;
using dotNetMicroservices.Ordering.Domain.Interfaces;
using dotNetMicroservices.Ordering.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotNetMicroservices.Ordering.Data.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private OrderingDbContext _orderingDbContext;

        public OrderRepository(OrderingDbContext orderingDbContext)
        {
            _orderingDbContext = orderingDbContext;
        }

        public IEnumerable<Order> GerOrders()
        {
            return _orderingDbContext.Orders;
        }
    }
}

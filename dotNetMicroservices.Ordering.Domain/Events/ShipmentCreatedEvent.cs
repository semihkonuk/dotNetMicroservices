using dotNetMicroservices.EventBus.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotNetMicroservices.Ordering.Domain.Events
{
    public class ShipmentCreatedEvent : Event
    {
        public string ProductName { get; set; }
        public string Address { get; set; }

        public ShipmentCreatedEvent(string productName,string address)
        {
            ProductName = productName;
            Address = address;
        }
    }
}

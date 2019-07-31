using dotNetMicroservices.EventBus.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotNetMicroservices.Ordering.Domain.Commands
{
    public class ShipmentCommand : Command
    {
        public string ProductName { get; protected set; }
        public string Address { get; protected set; }
    }
}

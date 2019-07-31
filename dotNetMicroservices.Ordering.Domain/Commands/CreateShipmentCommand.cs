using System;
using System.Collections.Generic;
using System.Text;

namespace dotNetMicroservices.Ordering.Domain.Commands
{
    public class CreateShipmentCommand : ShipmentCommand
    {
        public CreateShipmentCommand(string productName ,string address)
        {
            ProductName = productName;
            Address = address;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetMicroservices.Shipping.Api.Models
{
    public class Shipment
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Address { get; set; }
    }
}

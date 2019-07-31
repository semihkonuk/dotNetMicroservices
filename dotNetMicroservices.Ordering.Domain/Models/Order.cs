using System;
using System.Collections.Generic;
using System.Text;

namespace dotNetMicroservices.Ordering.Domain.Models
{
   public class Order
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Count { get; set; }
    }
}

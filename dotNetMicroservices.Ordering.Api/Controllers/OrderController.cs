using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotNetMicroservices.Ordering.Application.Interfaces;
using dotNetMicroservices.Ordering.Application.Models;
using dotNetMicroservices.Ordering.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotNetMicroservices.Ordering.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Order>> Get()
        {
            var a = _orderService.GetOrders();
            return Ok(a);
        }
        [HttpPost]
        public IActionResult Post ([FromBody] Shipment shipment)
        {
            _orderService.Shipment(shipment);
            return Ok(shipment);
        }

    }
}

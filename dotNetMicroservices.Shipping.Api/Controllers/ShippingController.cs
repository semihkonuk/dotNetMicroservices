using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotNetMicroservices.Shipping.Api.Models;
using dotNetMicroservices.Shipping.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotNetMicroservices.Shipping.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippingController : ControllerBase
    {
        private readonly IShippingService _shippingService;
        public ShippingController(IShippingService shippingService)
        {
            _shippingService = shippingService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Shipment>> GetShipments()
        {
            var a = _shippingService.GetShipments();
            return Ok(a);
        }

    }
}

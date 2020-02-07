using dotNetMicroservices.Shipping.Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetMicroservices.Shipping.Api.Data.Context
{
    public class ShippingDbContext : DbContext
    {
        public ShippingDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Shipment> Shipments { get; set; }
    }
}

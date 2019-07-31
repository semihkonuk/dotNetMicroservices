using dotNetMicroservices.Ordering.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotNetMicroservices.Ordering.Data.Context
{
    public class OrderingDbContext : DbContext
    {
        public OrderingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Order> Orders { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotNetMicroservices.EventBus.Bus;
using dotNetMicroservices.EventBusRabbitMQ;
using dotNetMicroservices.Ordering.Application.Interfaces;
using dotNetMicroservices.Ordering.Application.Services;
using dotNetMicroservices.Ordering.Data.Context;
using dotNetMicroservices.Ordering.Data.Repository;
using dotNetMicroservices.Ordering.Domain.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace dotNetMicroservices.Ordering.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<OrderingDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("OrderingDbConnection"));
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            SwaggerConfig(services);
            services.AddMediatR(typeof(Startup));
            RegisterServices(services);
        }

        private void SwaggerConfig(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "Ordering Microservices", Version = "v1" });
            });
        }

        private void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();
            //Aplication Service
            services.AddTransient<IOrderService, OrderService>();
            //Data
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<OrderingDbContext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Ordering Microservices v1");
            });
            app.UseMvc();
        }
    }
}

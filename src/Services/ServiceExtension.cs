﻿using Microsoft.Extensions.DependencyInjection;
using Services.AccountService;
using Services.OrderRowServices;
using Services.OrderServices;
using Services.ProductImportServices;
using Services.ProductServices;

namespace Services;

public static class ServiceExtension
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services
            .AddTransient(typeof(IAccountServices), typeof(AccountServices))
            .AddTransient(typeof(IOrderService), typeof(OrderService))
            .AddTransient(typeof(IOrderRowService), typeof(OrderRowService))
            .AddTransient(typeof(IProductServices), typeof(ProductServices.ProductServices))
            .AddTransient(typeof(IProductImportService), typeof(ProductImportService));
        return services;
    }
}
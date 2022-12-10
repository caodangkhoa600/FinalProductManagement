using Microsoft.Extensions.DependencyInjection;
using Repositories.AccountRepositories;
using Repositories.OrderRepositories;
using Repositories.OrderRowRepositories;
using Repositories.ProductImportRepositories;
using Repositories.ProductRepositories;
using Repository.OrderRowRepositories;

namespace Repositories;

public static class RepositoryExtension
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services
            .AddScoped<IAccountRepository, AccountRepository>()
            .AddScoped<IOrderRepository, OrderRepository>()
            .AddScoped<IOrderRowRepository, OrderRowRepository>()
            .AddScoped<IProductImportRepository, ProductImportRepository>()
            .AddScoped<IProductRepository, ProductRepository>();
        return services;
    }
}
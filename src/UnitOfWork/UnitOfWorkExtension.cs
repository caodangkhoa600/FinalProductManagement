using Microsoft.Extensions.DependencyInjection;

namespace UnitOfWork;

public static class UnitOfWorkExtension
{
    public static IServiceCollection AddUnitOfWork(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, global::UnitOfWork.UnitOfWork>();
        return services;
    } 
}
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Database;

public static class DbExtensions
{
    public static IServiceCollection AddSql(this IServiceCollection services, string connectionString, string migrationsAssembly)
    {
        services.AddDbContext<ApplicationDbContext>(c =>
            c.UseSqlServer(connectionString, sql =>
            {
                sql.MigrationsAssembly(migrationsAssembly);
            }));
        return services;
    }
    
}
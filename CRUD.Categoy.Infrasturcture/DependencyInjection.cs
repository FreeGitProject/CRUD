using CRUD.Category.Application.Abstractions.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;
using System.Data;
using CRUD.Category.Domain.Categories;
using CRUD.Category.Infrasturcture.Data;
using CRUD.Categoy.Infrasturcture.Repositories;
using CRUD.Category.Domain.Abstractions;
using CRUD.Category.Infrastructure;
using CRUD.Category.Application.Abstractions.Clock;
using CRUD.Category.Infrasturcture.Clock;
using CRUD.Category.Application.Abstractions.Caching;
using CRUD.Category.Infrasturcture.Caching;

namespace CRUD.Categoy.Infrasturcture;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddTransient<IDateTimeProvider, DateTimeProvider>();
        string connectionString = configuration.GetConnectionString("Database") ??
                                  throw new ArgumentNullException(nameof(configuration));

        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(connectionString).UseSnakeCaseNamingConvention());
       
        services.AddScoped<ICategoryRepository, CategoryRepository>();

        services.AddScoped<IUnitOfWork>(sp => sp.GetRequiredService<ApplicationDbContext>());

        services.AddSingleton<ISqlConnectionFactory>(_ =>
            new SqlConnectionFactory(connectionString));
        AddCaching(services, configuration);
        return services;
    }

    private static void AddCaching(IServiceCollection services, IConfiguration configuration)
    {
        string connectionString = configuration.GetConnectionString("Cache") ??
                                  throw new ArgumentNullException(nameof(configuration));

        services.AddStackExchangeRedisCache(options => options.Configuration = connectionString);

        services.AddSingleton<ICacheService, CacheService>();
    }
}
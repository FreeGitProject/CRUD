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
using CRUD.Category.Domain.Users;
using CRUD.Category.Infrasturcture.Repositories;
using CRUD.Category.Application.Abstractions.Authentication;
using CRUD.Category.Infrasturcture.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;

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
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();

        services.AddScoped<IUnitOfWork>(sp => sp.GetRequiredService<ApplicationDbContext>());

        services.AddSingleton<ISqlConnectionFactory>(_ =>
            new SqlConnectionFactory(connectionString));
        // AddCaching(services, configuration);

        AddAuthentication(services, configuration);
        return services;
    }

    //private static void AddCaching(IServiceCollection services, IConfiguration configuration)
    //{
    //    string connectionString = configuration.GetConnectionString("Cache") ??
    //                              throw new ArgumentNullException(nameof(configuration));

    //    services.AddStackExchangeRedisCache(options => options.Configuration = connectionString);

    //    services.AddSingleton<ICacheService, CacheService>();
    //}
    private static void AddAuthentication(IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer();

        services.Configure<AuthenticationOptions>(configuration.GetSection("Authentication"));

        services.ConfigureOptions<JwtBearerOptionsSetup>();

        services.Configure<KeycloakOptions>(configuration.GetSection("Keycloak"));

        services.AddTransient<AdminAuthorizationDelegatingHandler>();

        services.AddHttpClient<IAuthenticationService, AuthenticationService>((serviceProvider, httpClient) =>
        {
            var keycloakOptions = serviceProvider.GetRequiredService<IOptions<KeycloakOptions>>().Value;

            httpClient.BaseAddress = new Uri(keycloakOptions.AdminUrl);
        })
            .AddHttpMessageHandler<AdminAuthorizationDelegatingHandler>();

        services.AddHttpClient<IJwtService, JwtService>((serviceProvider, httpClient) =>
        {
            var keycloakOptions = serviceProvider.GetRequiredService<IOptions<KeycloakOptions>>().Value;

            httpClient.BaseAddress = new Uri(keycloakOptions.TokenUrl);
        });

        services.AddHttpContextAccessor();

        services.AddScoped<IUserContext, UserContext>();
    }
}
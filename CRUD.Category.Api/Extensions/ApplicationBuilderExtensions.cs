using CRUD.Category.Api.Middleware;
using CRUD.Category.Infrastructure;
using CRUD.Categoy.Infrasturcture;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Category.Api.Extensions
{
    internal static class ApplicationBuilderExtensions
    {
        public static void ApplyMigrations(this IApplicationBuilder app)
        {
            using IServiceScope scope = app.ApplicationServices.CreateScope();

            using ApplicationDbContext dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

            dbContext.Database.Migrate();
        }

        public static void UseCustomExceptionHandler(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionHandlingMiddleware>();
        }

        public static IApplicationBuilder UseRequestContextLogging(this IApplicationBuilder app)
        {
            app.UseMiddleware<RequestContextLoggingMiddleware>();

            return app;
        }
    }
}

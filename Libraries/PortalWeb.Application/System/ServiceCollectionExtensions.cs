using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PortalWeb.Infrastructure.Persistence;
using PortalWeb.Infrastructure.Persistence.EntityFramework;

namespace PortalWeb.Application.System
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection InjectApplicationServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
            return services;
        }

        public static IServiceCollection AddCustomizeDataStore(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PortalDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("PortalWeb.Infrastructure")));

            services.AddScoped<DbContext>(provider => provider.GetService<PortalDbContext>());
            return services;
        }
    }
}
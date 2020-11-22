﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using PortalWeb.Infrastructure.Persistence;
using PortalWeb.Infrastructure.Persistence.EntityFramework;
using System.Reflection;

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

        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }

        public static IServiceCollection IntegrateSwagger(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = configuration["Swagger:Title"],
                    Version = configuration["Swagger:Version"],
                    Description = configuration["Swagger:Description"]
                });
                options.CustomSchemaIds(x => x.FullName);
            });
            return services;
        }
    }
}
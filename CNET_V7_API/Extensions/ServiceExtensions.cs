﻿using CNET_V7_Logger;
using CNET_V7_Repository.Contracts;
using CNET_V7_Repository.Implementation;
using CNET_V7_Service.Contracts;
using CNET_V7_Service.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace CNET_V7_API.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            options.AddPolicy("CorsPolicy",
                builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader())
            );
        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options => { });

        public static void ConfigureLoggerService(this IServiceCollection services) =>
            services.AddSingleton<ILoggerManager, LoggerManager>();

        public static void ConfigureServiceManager(this IServiceCollection services) =>
            services.AddScoped<IServiceManager, ServiceManager>();

        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();

        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<CNET_V7_Entities.Data.CnetV7DbContext>(opts => opts.UseSqlServer(configuration.GetConnectionString("sqlConnection")));


    }
}
using Domain.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;

namespace Domain
{
    public static partial class ServiceExtensions
    {
        /// <summary>
        /// 配置数据库
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IServiceCollection ConfigDBContext(this IServiceCollection services, IConfiguration configuration)
        {
            return ConfigDBContext(services, configuration, "Default");
        }
        /// <summary>
        /// 配置数据库
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <param name="connectionName">数据库连接字符串的名字,默认为Default</param>
        /// <returns></returns>
        public static IServiceCollection ConfigDBContext(this IServiceCollection services, IConfiguration configuration, string connectionName)
        {
            var connection = configuration.GetConnectionString(connectionName);
            if (string.IsNullOrEmpty(connection))
            {
                throw new ArgumentNullException($"Please provide the DB connection with the {nameof(connectionName)}  name");
            }
            services.AddDbContext<RepositoryContext>(options =>
            {
                options.UseLazyLoadingProxies().UseSqlServer(connection, optionsAction =>
                {
                    var assembly = Assembly.GetAssembly(typeof(RepositoryContext)).GetName().Name;
                    optionsAction.MigrationsAssembly(assembly);
                    optionsAction.MigrationsHistoryTable("MigrationHistory", "dbo");
                });
            },ServiceLifetime.Singleton);
            return services;
        }

        
    }
}

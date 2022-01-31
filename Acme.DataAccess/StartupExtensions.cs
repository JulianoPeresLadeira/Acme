using Acme.DataAccess.Context;
using Acme.DataAccess.Entities;
using Acme.DataAccess.Repositories;
using Acme.DataAccess.Services;
using Acme.Domain.Facades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class StartupExtensions
    {
        public static IServiceCollection RegisterDataAccessServices(this IServiceCollection services, IConfiguration config)
        {
            services
                .AddTransient<IProductFacade, ProductRepository>()
                .AddTransient<IService<ProductEntity>, Service<ProductEntity>>();

            services
                .AddEntityFrameworkNpgsql()
                .AddDbContext<PostgreSQLContext>(options => options.UseNpgsql(config.GetSection("ConnectionString").GetValue<string>("PostgreSQLConnectionString")));

            return services;
        }

        public static IServiceCollection RegisterServices(IServiceCollection services, IConfiguration config)
        {
            services
                .AddTransient<IProductFacade, ProductRepository>()
                .AddTransient<IService<ProductEntity>, Service<ProductEntity>>();

            services
                .AddEntityFrameworkNpgsql()
                .AddDbContext<PostgreSQLContext>(options => options.UseNpgsql(config.GetSection("ConnectionString").GetValue<string>("PostgreSQLConnectionString")));

            return services;

        }
    }
}

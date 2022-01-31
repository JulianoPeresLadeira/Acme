using Acme.Api.Services;
using Acme.Api.Services.Interfaces;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class StartupExtensions
    {
        public static IServiceCollection RegisterApiDependencies(this IServiceCollection services, IConfiguration config)
        {
            services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            ConfigureDependencyInjection(services);

            return services;
        }

        private static void ConfigureDependencyInjection(this IServiceCollection services)
        {
            services.AddTransient<IProductService, ProductService>();
        }
    }
}

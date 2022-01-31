using Acme.Domain.DTOs;
using Acme.Domain.Facades;
using Acme.Sample.Objects;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Extensions.Hosting
{
    public static class HostExtensions
    {
        public static IHost SeedData(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                SeedProducts(services);
            }
            return host;
        }

        private static void SeedProducts(IServiceProvider services)
        {
            var repo = services.GetService<IProductFacade>();

            foreach (Product prd in Products.GetElements())
            {
                if (repo?.Get(prd.ID) == null) 
                { 
                    repo?.Create(prd);
                }
            }
        }
    }
}

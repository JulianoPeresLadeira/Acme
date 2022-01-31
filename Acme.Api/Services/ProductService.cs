using Acme.Api.Services.Interfaces;
using Acme.Domain.DTOs;
using Acme.Domain.Facades;

namespace Acme.Api.Services
{
    public class ProductService : IProductService
    {
        private IProductFacade _facade;
        public ProductService(IProductFacade facade)
        {
            _facade = facade;
        }

        public Product FindBySku(string SKU)
        {
            return _facade.FindBySku(SKU);
        }
    }
}

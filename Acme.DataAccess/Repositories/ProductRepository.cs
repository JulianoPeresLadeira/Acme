using Acme.DataAccess.Context;
using Acme.DataAccess.Converters;
using Acme.DataAccess.Entities;
using Acme.DataAccess.Services;
using Acme.Domain.DTOs;
using Acme.Domain.Facades;

namespace Acme.DataAccess.Repositories
{
    public class ProductRepository : CRUDRepository<ProductEntity, Product>, IProductFacade
    {
        private static IConverter ToEntity = new ProductToProducyEntityConverter();
        private static IConverter FromEntity = new ProductEntityToProductConverter();
        private PostgreSQLContext _context;

        public ProductRepository(
            PostgreSQLContext context,
            IService<ProductEntity> service) : base(
                ToEntity,
                FromEntity,
                service)
        {
            _context = context;
        }

        public Product FindBySku(string sku)
        {
            return _context.Products
                .Where(prd => sku.Equals(prd.SKU))
                .Select(FromEntity.Convert<ProductEntity, Product>)
                .FirstOrDefault();
        }
    }
}

using Acme.DataAccess.Entities;
using Acme.Domain.DTOs;

namespace Acme.DataAccess.Converters
{
    class ProductToProducyEntityConverter : BaseConverter
    {
        public ProductEntity Convert(Product from) => base.Convert<Product, ProductEntity>(from);
    }
}

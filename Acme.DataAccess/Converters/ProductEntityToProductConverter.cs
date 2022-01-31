using Acme.DataAccess.Entities;
using Acme.Domain.DTOs;

namespace Acme.DataAccess.Converters
{
    class ProductEntityToProductConverter : BaseConverter
    {
        public Product Convert(ProductEntity from) => base.Convert<ProductEntity, Product>(from);
    }
}

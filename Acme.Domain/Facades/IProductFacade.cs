using Acme.Domain.DTOs;

namespace Acme.Domain.Facades
{
    public interface IProductFacade : IFacade<Product>
    {
        Product FindBySku(string sku);
    }
}

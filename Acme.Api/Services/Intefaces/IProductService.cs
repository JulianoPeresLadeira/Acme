using Acme.Domain.DTOs;

namespace Acme.Api.Services.Interfaces
{
    public interface IProductService
    {
        Product FindBySku(string SKU);
    }
}
using Acme.Api.Services.Interfaces;
using Acme.DataAccess.Repositories;
using Acme.Domain.DTOs;
using Acme.Domain.Facades;
using Microsoft.AspNetCore.Mvc;

namespace Acme.Api.Controllers.V1
{
    [ApiController]
    [Route("v1/[controller]")]
    public class ProductController : ControllerBase
    {
        private IProductService _service;

        public ProductController(IProductService service) 
        {
            _service = service;
        }

        [HttpGet(Name = "GetTest")]
        public Product GetTest()
        {
            /*var prd = new Product
            {
                ID = 1,
                Name = "Test",
                Description = "Test Product init",
                SKU = "TEST666"
            };*/

            var prd = _service.FindBySku("TEST666");

            return prd;
        }
    }
}

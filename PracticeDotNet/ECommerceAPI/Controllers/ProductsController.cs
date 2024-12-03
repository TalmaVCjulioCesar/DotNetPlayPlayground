using ECommerceAPI.DTOs;
using ECommerceAPI.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProducts _products;

        public ProductsController(IProducts products) 
        { 
            _products = products;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductDto>> Get()
        {
            return await _products.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDto>> Get(int id)
        {
            var product = await _products.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return product;
        }
    }
}

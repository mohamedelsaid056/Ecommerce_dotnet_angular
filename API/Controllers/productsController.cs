using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Data;
using Core.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Core.Interfaces;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        

        private readonly IProductRepository ProductRepository;

        public ProductsController(IProductRepository productRepository)
        {
            ProductRepository = productRepository;
        }


        // GET: api/products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<product>>> GetProducts()
        {
            return Ok(await ProductRepository.GetAllProductAsync());
        }

        // GET: api/products/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<product>> GetProduct(int id)
        {
            var product = await ProductRepository.GetProductByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return product;
        }

        // POST: api/products
        [HttpPost]
        public async Task<ActionResult<product>> CreateProduct(product product)
        {
            await ProductRepository.CreateProductAsync(product);

            return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
        }

        // PUT: api/products/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            try
            {
                await ProductRepository.UpdateProductAsync(id, product);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (await ProductRepository.GetProductByIdAsync(id) == null)
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();

        }

        // DELETE: api/products/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            try
            {
                await ProductRepository.DeleteProductByIdAsync(id);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}


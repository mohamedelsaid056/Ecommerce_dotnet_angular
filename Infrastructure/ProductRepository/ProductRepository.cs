using Core.Interfaces;
using Core.models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Core.Interfaces.IProductRepository;


namespace Infrastructure.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        // inject the database context
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<product> CreateProductAsync(product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task DeleteProductByIdAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                throw new KeyNotFoundException($"Product with id {id} not found.");
            }
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<product>> GetAllProductAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<product> GetProductByIdAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                throw new KeyNotFoundException($"Product with id {id} not found.");
            }
            return product;
        }

        public async Task UpdateProductAsync(int id, product product)
        {
            if (id != product.Id)
            {
                throw new ArgumentException("Product ID mismatch.");
            }
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }

        
    }
}
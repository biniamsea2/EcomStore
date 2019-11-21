using ECom.Data;
using ECom.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECom.Models.Services
{
    public class ProductService : IInventory
    {
        private StoreDbContext _context;
        public ProductService(StoreDbContext context)
        {
            _context = context;
        }
        public async Task CreateProductAsync(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(int id)
        {
            Product product = await GetProductByIDAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }

        public async Task<Product> GetProductByIDAsync(int id) => await _context.Products.FirstOrDefaultAsync(pd1 => pd1.ID == id);

        public async Task<List<Product>> GetProductsAsync()
        {
            List<Product> products = await _context.Products.ToListAsync();
            return products;
        }

        public async Task UpdateProductAsync(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }
    }
}

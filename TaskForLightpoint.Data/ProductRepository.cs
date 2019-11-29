using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskForLightpoint.Models;
using System.Linq;

namespace TaskForLightpoint.Data
{
    public class ProductRepository : IProductRepository
    {
        private TaskForLightpointContext _context;
        public ProductRepository(TaskForLightpointContext context)
        {
            _context = context;
        }

        public async Task CreateProduct(Product product)
        {
            _context.Add(product);
            int save = await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _context.Product.ToListAsync();
        }

        public async Task<Product> GetProduct(Guid id)
        {
            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.Id == id);
            return product;
        }

        public async Task DeleteProduct(Guid id)
        {
            var product = await _context.Product.FindAsync(id);
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProduct(Product product)
        {
            _context.Update(product);
            int ass = await _context.SaveChangesAsync();
        }

        public bool ProductExist(Guid id)
        {
            return _context.Product.Any(e => e.Id == id);
        }
    }
}

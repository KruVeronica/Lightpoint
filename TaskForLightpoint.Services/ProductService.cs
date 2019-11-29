using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TaskForLightpoint.Data;
using TaskForLightpoint.Models;

namespace TaskForLightpoint.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task CreateProduct(Product product)
        {
            await _productRepository.CreateProduct(product);
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            var products = await _productRepository.GetAllProducts();
            return products;
        }

        public async Task<Product> GetProduct(Guid id)
        {
            var product = await _productRepository.GetProduct(id);
            return product;
        }

        public async Task DeleteProduct(Guid id)
        {
            await _productRepository.DeleteProduct(id);
        }

        public async Task UpdateProduct(Product product)
        {
            await _productRepository.UpdateProduct(product);
        }

        public bool ProductExist(Guid id)
        {
            bool ifExist = _productRepository.ProductExist(id);
            return ifExist;
        }
    }
}

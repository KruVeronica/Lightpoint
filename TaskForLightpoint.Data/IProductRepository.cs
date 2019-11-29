using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TaskForLightpoint.Models;

namespace TaskForLightpoint.Data
{
    public interface IProductRepository
    {
        Task CreateProduct(Product product);
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProduct(Guid id);
        Task DeleteProduct(Guid id);
        Task UpdateProduct(Product product);
        bool ProductExist(Guid id);

    }
}

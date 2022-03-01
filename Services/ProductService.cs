using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Services
{
    public class ProductService : IProductService
    {
        public ProductService()
        {

        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            var products = await Task.Run(() => this.GetProducts());
            return products;
        }

        private IEnumerable<Product> GetProducts()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "laptop", Price = 60000 },
                new Product { Id = 1, Name = "mobile", Price = 60000 },
            };

            return products;
        }
    }
}
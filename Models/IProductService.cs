using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProductsAsync();
    }
}

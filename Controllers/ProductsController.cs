using System.Threading.Tasks;
using System.Web.Http;
using WebApi.Attributes;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Log]
    [RoutePrefix("products")]
    public class ProductsController : ApiController
    {
        private IProductService ProductService { get; set; }

        public ProductsController(IProductService productService)
        {
            ProductService = productService;
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetProductsAsync()
        {
            var products = await this.ProductService.GetProductsAsync().ConfigureAwait(false);
            return Ok(products);
        }

        [HttpGet]
        public IHttpActionResult GetProduct(string id)
        {
            return Ok(id);
        }

        [HttpPost]
        public IHttpActionResult AddProducts()
        {
            return Ok();
        }

        [HttpPatch]
        public IHttpActionResult UpdateProducts()
        {
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult DeleteProducts()
        {
            return Ok();
        }
    }
}

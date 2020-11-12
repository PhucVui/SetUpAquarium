using Microsoft.AspNetCore.Mvc;
using SetupAquarium.BAL.Interface;
using SetupAquarium.Domain.Request.Product;
using System.Threading.Tasks;

namespace SetupAquarium.API.Controllers
{

    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet("api/product/gets")]
        public async Task<OkObjectResult> Gets()
        {
            var products = await productService.Gets();
            return Ok(products);
        }

        [HttpGet("api/product/get/{id}")]
        public async Task<OkObjectResult> Get(int id)
        {
            var product = await productService.Get(id);
            return Ok(product);
        }

        [HttpPost, HttpPatch]
        [Route("api/product/save")]
        public async Task<OkObjectResult> Save(SaveProductReq request)
        {
            var result = await productService.Save(request);
            return Ok(result);
            
        }

        [HttpPatch]
        [Route("api/product/changeProductStatus/{id}/{status}")]
        public async Task<OkObjectResult> ChangeProductStatus(int id, int status)
        {
            var result = await productService.ChangeProductStatus(id, status);
            return Ok(result);
        }
    }
}

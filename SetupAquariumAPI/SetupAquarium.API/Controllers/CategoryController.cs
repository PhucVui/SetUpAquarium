using Microsoft.AspNetCore.Mvc;
using SetupAquarium.BAL.Interface;
using SetupAquarium.Domain.Request.Category;
using System.Threading.Tasks;

namespace SetupAquarium.API.Controllers
{

    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet("api/category/gets")]
        public async Task<OkObjectResult> Gets()
        {
            var products = await categoryService.Gets();
            return Ok(products);
        }

        [HttpGet("api/category/get/{id}")]
        public async Task<OkObjectResult> Get(int id)
        {
            var product = await categoryService.Get(id);
            return Ok(product);
        }

        [HttpPost, HttpPatch]
        [Route("api/category/save")]
        public async Task<OkObjectResult> Save(SaveCategoryReq request)
        {
            var result = await categoryService.Save(request);
            return Ok(result);

        }

        [HttpPatch]
        [Route("api/category/changeCategoryStatus/{id}/{status}")]
        public async Task<OkObjectResult> ChangeCategoryStatus(int id, int status)
        {
            var result = await categoryService.ChangeCategoryStatus(id, status);
            return Ok(result);
        }
    }
}

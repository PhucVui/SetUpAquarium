using Microsoft.AspNetCore.Mvc;

namespace SetupAquariumWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

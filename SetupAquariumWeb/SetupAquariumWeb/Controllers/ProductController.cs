using Microsoft.AspNetCore.Mvc;

namespace SetupAquariumWeb.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

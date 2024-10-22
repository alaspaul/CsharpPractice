using Microsoft.AspNetCore.Mvc;

namespace ViewsPractice.Controllers
{
    public class ProductController : Controller
    {
        [Route("/Product/All")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

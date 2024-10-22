using Microsoft.AspNetCore.Mvc;

namespace LayoutViewPractice.Controllers
{
    public class ProductController : Controller
    {
        [Route("/Products")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/Search/{ProductId}")]
        public IActionResult Search(int ProductId)
        {
            ViewBag.ProductId = ProductId;
            return View();
        }

        [Route("/Order")]
        public IActionResult Order()
        {
            return View();
        }
    }
}

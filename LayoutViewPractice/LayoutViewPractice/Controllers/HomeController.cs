using Microsoft.AspNetCore.Mvc;

namespace LayoutViewPractice.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/About-Us")]
        public IActionResult About()
        {
            return View();
        }

        [Route("/Contact-Us")]
        public IActionResult Contact()
        {
            return View();
        }
    }
}

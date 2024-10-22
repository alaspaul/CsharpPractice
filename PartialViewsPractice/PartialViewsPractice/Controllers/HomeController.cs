using Microsoft.AspNetCore.Mvc;

namespace PartialViewsPractice.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            ViewData["ListTitle"] = "cities";

            ViewData["ListItems"] = new List<string>()
            {
                "Paris",
                "new york",
                "mumbai",
            };
            return View();
        }

        [Route("/About")]
        public IActionResult About()
        {
            return View();
        }
    }
}

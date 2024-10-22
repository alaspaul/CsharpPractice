using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ConfigurationExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly WeatherApiOptions _configuration;

        public HomeController(IOptions<WeatherApiOptions> configuration)
        {
            _configuration = configuration.Value;
        }

        [Route("/")]
        public IActionResult Index()
        {

            ViewBag.Mykey = _configuration.ClientID;
            ViewBag.Mykey2 = _configuration.ClientSecret;
            return View();
        }
    }
}

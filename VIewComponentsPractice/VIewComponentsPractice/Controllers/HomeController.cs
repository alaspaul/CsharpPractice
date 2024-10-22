using Microsoft.AspNetCore.Mvc;
using VIewComponentsPractice.Models;

namespace VIewComponentsPractice.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/About")]
        public IActionResult About()
        {
            return View();
        }

        [Route("/Persons")]
        public IActionResult LoadPersonsList()
        {
            
                PersonGridModel model = new PersonGridModel()
                {
                    GridTitle = "PersonList",
                    Persons = new List<Person>()
               {
                   new Person(){Name = "paul", Age = 21},
                   new Person(){Name = "sad", Age = 21},
                   new Person(){Name = "das", Age = 21},
               }

                };

            return ViewComponent("Grid", new {grid = model});
        }
    }
}

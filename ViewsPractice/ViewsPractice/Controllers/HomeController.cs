using Microsoft.AspNetCore.Mvc;
using ViewsPractice.Models;

namespace ViewsPractice.Controllers
{
    public class HomeController : Controller
    {
        [Route("/Home")]
        [Route("/")]
        public IActionResult Index()
        {
            ViewData["appTitle"] = "Views Practice From Cnt";

            List<Person> persons = new List<Person>()
            {
                new Person(){ Name = "paul" , Age = 25, DateOfBirth = DateTime.Now },
                new Person(){ Name = "steve" , Age = 21, DateOfBirth = DateTime.Now },
                new Person(){ Name = "kyler" , Age = 15, DateOfBirth = DateTime.Now },
            };


            ViewData["persons"] = persons;
            return View();
        }

        [Route("/Details/{name}")]

        public IActionResult Details(string? name)
        {

            List<Person> persons = new List<Person>()
            {
                new Person(){ Name = "paul" , Age = 25, DateOfBirth = DateTime.Now },
                new Person(){ Name = "steve" , Age = 21, DateOfBirth = DateTime.Now },
                new Person(){ Name = "kyler" , Age = 15, DateOfBirth = DateTime.Now },
            };

            if (string.IsNullOrEmpty(name))
            {
                return Content("name cannot be null");
            }

            Person person = persons.Where(Temp => Temp.Name == name).FirstOrDefault();


            return View(person);
        }

        [Route("/PersonProduct")]
        public IActionResult PersonWithProduct()
        {
            Person person = new Person() { Name = "paul", Age = 25, DateOfBirth = DateTime.Now };
            Product product = new Product() { Id = 1, Name = "somehitng" };

            PersonAndProductWrapperModel personProduct = new PersonAndProductWrapperModel()
            { PersonData = person, ProductData = product };
            return View(personProduct);
        }
    }
}

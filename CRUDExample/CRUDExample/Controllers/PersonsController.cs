using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;
using ServiceContracts;
using ServiceContracts.DTO;
using System.Runtime.CompilerServices;

namespace CRUDExample.Controllers
{
    public class PersonsController : Controller
    {
        private readonly IPersonsService _personsService;

        public PersonsController(IPersonsService personsService)
        {
            _personsService = personsService;
        }

        [Route("/persons/index")]
        [Route("/")]
        public IActionResult Index(string? searchBy, string? searchString)
        {
            ViewBag.SearchFields = new Dictionary<string, string>() 
            {
                { nameof(PersonResponse.PersonName), "Name" },
                { nameof(PersonResponse.PersonEmail), "Email" },
                { nameof(PersonResponse.Address), "Address" },
            };
            ViewBag.SearchString = searchString;
            ViewBag.SearchBy = searchBy;
            List<PersonResponse> persons = _personsService.
                                            GetFilteredPersons(searchBy,searchString);
            return View(persons);
        }
    }
}

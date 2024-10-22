using Microsoft.AspNetCore.Mvc;
using ModelValidationPractice.Models;
using ModelValidationPractice.CustomModelBinders;

namespace ModelValidationPractice.Controllers
{
    public class PersonController : Controller
    {
        [Route("Register")]

        //public IActionResult Index([Bind(nameof(Person.Name), nameof(Person.Email))] // bind only allows values of given names to receive data or to be bound to a given data
        //Person person)
        public IActionResult Index(
        Person person)
        {
            if (!ModelState.IsValid)
            {
                List<string> errorList = new List<string>();

                //short version
                errorList = ModelState.Values.SelectMany(value => value.Errors).Select(err => err.ErrorMessage).ToList();
               
                //foreach(var value in ModelState.Values) //long version
                //{
                //    foreach (var error  in value.Errors)
                //    {
                //        errorList.Add(error.ErrorMessage);

                //    }
                //}


                string errors = string.Join("\n", errorList);
                return BadRequest(errors);
            }

            return Content($"{person}"); 
        }

        [Route("Register/FromBody")]
        public IActionResult FromBody([FromBody] // accepts data frombody json XML
                                       [ModelBinder(BinderType = typeof(PersonModelBinder))] // uses the custom model binder to the class in the parameter instead of the default
        Person person)
        {
            if (!ModelState.IsValid)
            {
                List<string> errorList = new List<string>();

                errorList = ModelState.Values.SelectMany(value => value.Errors).Select(err => err.ErrorMessage).ToList();



                string errors = string.Join("\n", errorList);
                return BadRequest(errors);
            }

            return Content($"{person}");
        }
    }
}

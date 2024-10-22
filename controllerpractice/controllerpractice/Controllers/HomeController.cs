using Microsoft.AspNetCore.Mvc;
using controllerpractice.Models;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace controllerpractice.Controllers
{
    [Controller]
    public class HomeController : Controller
    {
        //[Route("home")]
        //[Route("/")]
        public ContentResult ContentResult ()
        {
            //return new ContentResult()
            //{
            //    Content = "hello from content result"
            //    ,
            //    ContentType = "text/plain"
            //};

            return Content("hello from index content", "text/plain");
        }

        //[Route("person")]
        //[Route("/")]
        public JsonResult JsonResult()
        {
            Person person = new Person()
            {
                Id = Guid.NewGuid(),
                FirstName = "Test",
                LastName = "Test",
                Age = 1,
            };
            
            return Json(person);

            //return new JsonResult(person);

            //return " {\" key \" : \" value \"} ";
        }


        //[Route("virtualfile-download")]
        //[Route("/")]
        public VirtualFileResult VirtualFileResult()
        {
            //return new VirtualFileResult("/notes section 3.pdf", 
            //                             "application/pdf");

            return File("/notes section 3.pdf", "application/pdf");
        }


        //[Route("physicalfile-download")]
        //[Route("/")]
        public PhysicalFileResult PhysicalFileResult()
        {
            //return new PhysicalFileResult(@"C:\Users\paul\source\repos\controllerpractice\controllerpractice\wwwroot\notes section 3.pdf",
            //                             "application/pdf");

            return PhysicalFile(@"C:\Users\paul\source\repos\controllerpractice\controllerpractice\wwwroot\notes section 3.pdf",
                                         "application/pdf");
        }


        //[Route("contentfile-download")]
        //[Route("/")]
        public FileContentResult ContentFileResult()
        {
            byte[] bytes = System.IO.File.ReadAllBytes(@"C:\Users\paul\source\repos\controllerpractice\controllerpractice\wwwroot\notes section 3.pdf");

            //return new FileContentResult(bytes, "application/pdf");

            return File(bytes, "application/pdf");
        }

        //[Route("IActionResult-download")]
        //[Route("/")]
        public IActionResult IActionResult()
        {
            byte[] bytes = System.IO.File.ReadAllBytes(@"C:\Users\paul\source\repos\controllerpractice\controllerpractice\wwwroot\notes section 3.pdf");

            //return new FileContentResult(bytes, "application/pdf");

            return File(bytes, "application/pdf");
        }

    }
}

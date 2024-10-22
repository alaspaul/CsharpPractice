using Microsoft.AspNetCore.Mvc;
using ModelBindingPractice.Models
namespace IActionResultPractice.Controllers
{
    public class HomeController : Controller
    {

        [Route("bookstore")]
        public IActionResult Index()
        {

            if (!Request.Query.ContainsKey("bookid"))
            {
                return BadRequest("bookId is not supplied");
            }


            if (string.IsNullOrEmpty(Convert.ToString(Request.Query.ContainsKey("bookid"))))
            {
                return BadRequest("bookid cannot be null or empty");
            }

            int bookId = Convert.ToInt32(ControllerContext.HttpContext.Request.Query["bookid"]);

            if (bookId <= 0)
            {
                return BadRequest("bookId cannot be zero");

            }else if (bookId > 1000)
            {
                return BadRequest("bookId cannot be greater than 1000");
            }

            if (Convert.ToBoolean(Request.Query["IsLoggedIn"]) == false)
            {
                return Unauthorized("User must be authenticated");
            }


            return new RedirectToActionResult("Books", "Store", new {id = bookId}); //302 - found only

            return RedirectToAction("Books", "Store", new { }); // short way to redirect

            return new RedirectToActionResult("Books", "Store", new { }, true); //301 - permanently moved will save the url to the browser

            return RedirectToActionPermanent("Books", "Store", new { }); // short way to redirect permanently


        }
    }
}

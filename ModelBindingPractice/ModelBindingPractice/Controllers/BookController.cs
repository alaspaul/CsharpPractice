using Microsoft.AspNetCore.Mvc;
using ModelBindingPractice.Models;
namespace ModelBindingPractice.Controllers
{
    public class BookController : Controller
    {
        [Route("bookstore")]
        public IActionResult Index([FromQuery]bool? isLoggedIn, Book book)
        {

            if (book.BookId.HasValue == false)
            {
                return BadRequest("bookId is not supplied");
            }


            if (book.BookId <= 0)
            {
                return BadRequest("bookId cannot be zero");

            }
            else if (book.BookId > 1000)
            {
                return BadRequest("bookId cannot be greater than 1000");
            }

            if (Convert.ToBoolean(Request.Query["IsLoggedIn"]) == false)
            {
                return Unauthorized("User must be authenticated");
            }

            return Content($"book {book}");

        }

    }
}

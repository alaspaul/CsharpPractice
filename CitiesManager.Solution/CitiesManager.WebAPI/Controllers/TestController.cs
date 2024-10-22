using Microsoft.AspNetCore.Mvc;

namespace CitiesManager.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpPost]
        public string method()
        {
            return "Hello World";
        }
    }
}

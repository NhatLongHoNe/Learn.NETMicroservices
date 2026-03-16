using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers
{
    [ApiController]
    [Route("api/c/[controller]")]
    public class PlatformsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPlatforms()
        {
            return Ok("Hello World");
        }

        [HttpPost]
        public ActionResult TestInBoundConnection()
        {
            Console.WriteLine("--> Inbound POST # event");
            return Ok("In bound connection");
        }

    }
}
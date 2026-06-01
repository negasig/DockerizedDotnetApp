

using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace DockerizedApp.Controller
{
    [ApiController]
    [Route("api")]

    public class EmpController:ControllerBase
    {
        [HttpGet("test")]
        
        public ActionResult<string> Test()
        {
             return Ok("Test Api Docker");
        }
        [HttpGet("login")]
        public ActionResult<string> Login()
        {
            return Ok("Test Login");
        }

        public ActionResult<string> Register()
        {
            return Ok("Register successfully");
        }
    }
}



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

    }
}

using Microsoft.AspNetCore.Mvc;

namespace Finstro.CodingExercise.Controllers
{
    [ApiController]
    [Route("Home")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Welcome to Finstro";
        }
    }
}

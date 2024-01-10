using Microsoft.AspNetCore.Mvc;

namespace ms1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            var items = new List<string> { "Item1", "Item2", "Item3" };
            return Ok(items);
        }
    }
}
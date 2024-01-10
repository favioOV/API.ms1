using Microsoft.AspNetCore.Mvc;

namespace ms1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<Person> items = new();

            items.Add(new Person() { Name = "Pepe" });
            items.Add(new Person() { Name = "Pipo" });

            return Ok(items);
        }
    }

    
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public int? Age { get; set; }
        public string Address { get; set; }
    }

     
}
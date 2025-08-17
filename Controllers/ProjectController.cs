using Microsoft.AspNetCore.Mvc;

namespace MythMakers.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectController : Controller
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(new[] { "project1", "project2" });
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(new { Id = id, Name = $"Project {id}" });
        }

        [HttpPost]
        public IActionResult CreateOrUpdate()
        {
            return View();
        }

        [HttpDelete]
        public IActionResult Delete() 
        {
            return View(null);
        }
    }
}

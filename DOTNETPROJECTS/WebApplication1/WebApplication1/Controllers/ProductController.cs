using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    //controller is an attribute
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult Read(int id)
        {
            return Ok(new { id, Name = "roja"});

        }
        [HttpPost]
        public IActionResult Create(WeatherForecast weatherForecast)
        {
            return Created(string.Empty, weatherForecast);
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, WeatherForecast weatherForecast)
        {
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete (int id)
        {
            return NoContent();
        }
    }
}

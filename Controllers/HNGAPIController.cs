using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HNGAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HNGAPIController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var response = new
            {
                email = "akoredehabeeb958@gmail.com",
                current_datetime = DateTime.UtcNow.ToString("o"),
                github_url = "https://github.com/Habeeb958/HNGapi" // Replace with your GitHub repo URL
            };

            return Ok(response);
        }

    }
}

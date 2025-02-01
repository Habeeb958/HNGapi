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
                RegisteredEmail = "akoredehabeeb958@gmail.com",
                CurrentDateTime = DateTime.UtcNow.ToString("o"),
                GitHubURL = "https://github.com/Habeeb958/HNG12PublicAPI.git" // Replace with your GitHub repo URL
            };

            return Ok(response);
        }
    
    }
}

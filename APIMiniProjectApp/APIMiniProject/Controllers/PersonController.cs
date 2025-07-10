using APIMiniProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIMiniProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        // POST api/<PersonController>
        [HttpPost]
        public void Post([FromBody] PersonModel data)
        {
        }
    }
}

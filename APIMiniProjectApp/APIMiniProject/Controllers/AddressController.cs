using APIMiniProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIMiniProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        // POST api/<PersonController>
        [HttpPost]
        public void Post([FromBody] AddressModel data)
        {
        }
    }
}

using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace UserManager.Api.Controllers.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult Users()
        {
            return Ok();
        }
    }
}

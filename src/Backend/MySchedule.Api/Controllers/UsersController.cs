using Microsoft.AspNetCore.Mvc;
using MySchedule.Communication.Requests;

namespace MySchedule.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpPost]
        public IActionResult Register([FromBody] RequestRegisterUserAccountJson userAccountJson)
        {
            return Created();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using MySchedule.Application.UseCases.User.Register;
using MySchedule.Communication.Requests;
using MySchedule.Exception.ExceptionsBase;

namespace MySchedule.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpPost]
        public IActionResult Register([FromBody] RequestRegisterUserAccountJson userAccountJson)
        {
            var useCase = new RegisterUserAccountUseCase();

            useCase.Execute(userAccountJson);

            return Created();
        }
    }
}

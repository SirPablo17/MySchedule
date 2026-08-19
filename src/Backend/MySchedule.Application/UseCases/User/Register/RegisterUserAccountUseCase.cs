using MySchedule.Application.UseCases.User.Register;
using MySchedule.Communication.Requests;

namespace MySchedule.Application.UseCases.User.Register;

public class RegisterUserAccountUseCase
{
    public void Execute(RequestRegisterUserAccountJson registerUserAccountJson)
    {
        var validator = new RegisterUserAccountValidator();

        var result = validator.Validate(registerUserAccountJson);
    }
}
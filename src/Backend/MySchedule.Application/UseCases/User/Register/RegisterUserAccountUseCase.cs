using MySchedule.Application.UseCases.User.Register;
using MySchedule.Communication.Requests;
using MySchedule.Exception.ExceptionsBase;

namespace MySchedule.Application.UseCases.User.Register;

public class RegisterUserAccountUseCase
{
    public void Execute(RequestRegisterUserAccountJson registerUserAccountJson)
    {
        var validator = new RegisterUserAccountValidator();

        var result = validator.Validate(registerUserAccountJson);

        if (!result.IsValid)
        {
            var errorMessages = result.Errors.Select(error => error.ErrorMessage).ToList();
            
            throw new ErrorOnValidationException(errorMessages);
        }
    }
}
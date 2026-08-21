using System.Data;
using FluentValidation;
using MySchedule.Communication.Requests;
using MySchedule.Exception;

namespace MySchedule.Application.UseCases.User.Register;

public class RegisterUserAccountValidator : AbstractValidator<RequestRegisterUserAccountJson>
{
    public RegisterUserAccountValidator()
    {
        RuleFor(user => user.Name).NotEmpty().WithMessage(ResourceMessageException.VALIDATION_NAME_REQUIRED);
        RuleFor(user => user.Email).NotEmpty().WithMessage(ResourceMessageException.VALIDATION_EMAIL_REQUIRED);
        RuleFor(user => user.Password).NotEmpty().WithMessage(ResourceMessageException.VALIDATION_PASSWORD_REQUIRED);
        When(user => string.IsNullOrWhiteSpace(user.Email) == false, () =>
        {
            RuleFor(user => user.Email).EmailAddress().WithMessage(ResourceMessageException.VALIDATION_EMAIL_INVALID);
        });
    }
}
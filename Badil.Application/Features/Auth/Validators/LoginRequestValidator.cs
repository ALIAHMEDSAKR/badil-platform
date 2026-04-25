using Badil.Application.Features.Auth.DTOs;
using FluentValidation;

namespace Badil.Application.Features.Auth.Validators
{
    public class LoginRequestValidator : AbstractValidator<Commands.LoginCommand>
    {
        public LoginRequestValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required")
                .EmailAddress().WithMessage("A valid email address is required");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required")
                .MinimumLength(8).WithMessage("Password must be at least 8 characters");
        }
    }
}

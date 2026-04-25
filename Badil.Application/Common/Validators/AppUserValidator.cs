using Badil.Domain.Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Badil.Application.Common.Validators
{
    public class AppUserValidator : AbstractValidator<AppUser>
    {
        public AppUserValidator()
        {
            // FirstName
            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("First name is required.")
                .MaximumLength(50).WithMessage("First name must not exceed 50 characters.")
                .Matches(@"^[a-zA-Z\s]+$").WithMessage("First name can only contain letters.");

            // LastName
            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Last name is required.")
                .MaximumLength(50).WithMessage("Last name must not exceed 50 characters.")
                .Matches(@"^[a-zA-Z\s]+$").WithMessage("Last name can only contain letters.");

            // Email (inherited from IdentityUser)
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email format.")
                .MaximumLength(100).WithMessage("Email must not exceed 100 characters.");

            // PhoneNumber (inherited from IdentityUser)
            RuleFor(x => x.PhoneNumber)
                .Matches(@"^\+?[0-9]{7,15}$").WithMessage("Invalid phone number format.")
                .When(x => !string.IsNullOrEmpty(x.PhoneNumber));

            // Role
            RuleFor(x => x.Role)
                .IsInEnum().WithMessage("Invalid user role.");

            // CreatedAt
            RuleFor(x => x.CreatedAt)
                .NotEmpty().WithMessage("CreatedAt is required.")
                .LessThanOrEqualTo(DateTime.UtcNow).WithMessage("CreatedAt cannot be in the future.");

            // UpdatedAt
            RuleFor(x => x.UpdatedAt)
                .GreaterThanOrEqualTo(x => x.CreatedAt)
                .WithMessage("UpdatedAt must be after CreatedAt.")
                .When(x => x.UpdatedAt.HasValue);
        }
        
}
}

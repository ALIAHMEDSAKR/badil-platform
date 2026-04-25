using Badil.Domain.Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Common.Validators
{
    public class CompanyValidator : BaseAuditableEntityValidator<Company>
    {
        public CompanyValidator()
        {
           
            // UserId
            RuleFor(x => x.UserId)
                .NotEmpty()
                .WithMessage("UserId is required.");

            // Name
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Company name is required.")
                .MinimumLength(2).WithMessage("Company name must be at least 2 characters.")
                .MaximumLength(100).WithMessage("Company name must not exceed 100 characters.")
                .Matches(@"^[a-zA-Z0-9\s\-\.]+$").WithMessage("Company name contains invalid characters.");

            // Sector
            RuleFor(x => x.Sector)
                .NotEmpty().WithMessage("Sector is required.")
                .MaximumLength(100).WithMessage("Sector must not exceed 100 characters.");

            // Address
            RuleFor(x => x.Address)
                .NotEmpty().WithMessage("Address is required.")
                .MaximumLength(250).WithMessage("Address must not exceed 250 characters.");

            // Location
            RuleFor(x => x.Location)
                .NotNull().WithMessage("Location is required.");

            RuleFor(x => x.Location.Latitude)
                .InclusiveBetween(-90, 90)
                .WithMessage("Latitude must be between -90 and 90.")
                .When(x => x.Location != null);

            RuleFor(x => x.Location.Longitude)
                .InclusiveBetween(-180, 180)
                .WithMessage("Longitude must be between -180 and 180.")
                .When(x => x.Location != null);

            // TaxRegistrationNumber
            RuleFor(x => x.TaxRegistrationNumber)
                .NotEmpty().WithMessage("Tax registration number is required.")
                .Matches(@"^\d{9,15}$")
                .WithMessage("Tax registration number must be 9 to 15 digits only.");

            // CommercialRegisterNumber
            RuleFor(x => x.CommercialRegisterNumber)
                .NotEmpty().WithMessage("Commercial register number is required.")
                .Matches(@"^\d{6,15}$")
                .WithMessage("Commercial register number must be 6 to 15 digits only.");
        }
    }
}

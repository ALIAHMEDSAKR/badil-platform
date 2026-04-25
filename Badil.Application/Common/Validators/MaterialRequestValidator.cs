using Badil.Domain.Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Common.Validators
{
    public class MaterialRequestValidator : BaseAuditableEntityValidator<MaterialRequest>
    {
        public MaterialRequestValidator()
        {
            // UserId
            RuleFor(x => x.UserId)
                .NotEmpty()
                .WithMessage("UserId is required.");

            // MaterialType
            RuleFor(x => x.MaterialType)
                .NotEmpty().WithMessage("Material type is required.")
                .MaximumLength(100).WithMessage("Material type must not exceed 100 characters.");

            // TargetQuantity
            RuleFor(x => x.TargetQuantity)
                .GreaterThan(0).WithMessage("Target quantity must be greater than 0.");

            // LocationPreferenceRadiusKm
            RuleFor(x => x.LocationPreferenceRadiusKm)
                .GreaterThan(0).WithMessage("Radius must be greater than 0 km.")
                .LessThanOrEqualTo(500).WithMessage("Radius cannot exceed 500 km.");
        }
    }
}

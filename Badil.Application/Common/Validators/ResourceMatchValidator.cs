using Badil.Domain.Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Common.Validators
{
    public class ResourceMatchValidator : BaseAuditableEntityValidator<ResourceMatch>
    {
        public ResourceMatchValidator()
        {
            // ListingId
            RuleFor(x => x.ListingId)
                .NotEmpty().WithMessage("ListingId is required.");

            // RequestId
            RuleFor(x => x.RequestId)
                .NotEmpty().WithMessage("RequestId is required.");

            // SemanticCompatibilityScore
            RuleFor(x => x.SemanticCompatibilityScore)
                .InclusiveBetween(0, 1)
                .WithMessage("Semantic score must be between 0 and 1.");

            // DistanceKm
            RuleFor(x => x.DistanceKm)
                .GreaterThanOrEqualTo(0).WithMessage("Distance cannot be negative.");
        }
    }
}

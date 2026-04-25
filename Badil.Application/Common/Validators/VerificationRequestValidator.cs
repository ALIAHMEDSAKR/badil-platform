using Badil.Domain.Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Common.Validators
{
    public class VerificationRequestValidator : BaseAuditableEntityValidator<VerificationRequest>
    {
        public VerificationRequestValidator()
        {
            // CompanyId
            RuleFor(x => x.CompanyId)
                .NotEmpty().WithMessage("CompanyId is required.");

            // DocumentUrls
            RuleFor(x => x.DocumentUrls)
                .NotNull().WithMessage("Document URLs are required.")
                .Must(docs => docs.Count >= 1).WithMessage("At least one document is required.")
                .Must(docs => docs.Count <= 10).WithMessage("Cannot upload more than 10 documents.");

            RuleForEach(x => x.DocumentUrls)
                .Must(url => Uri.TryCreate(url, UriKind.Absolute, out _))
                .WithMessage("Each document must be a valid URL.");

            // Status
            RuleFor(x => x.Status)
                .IsInEnum().WithMessage("Invalid verification status.");
        }
    }
}

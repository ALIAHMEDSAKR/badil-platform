using Badil.Domain.Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Common.Validators
{
    public class DisputeTicketValidator : BaseAuditableEntityValidator<DisputeTicket>
    {
        public DisputeTicketValidator()
        {
            // TransactionId
            RuleFor(x => x.TransactionId)
                .NotEmpty().WithMessage("TransactionId is required.");

            // RaisedByUserId
            RuleFor(x => x.RaisedByUserId)
                .NotEmpty().WithMessage("RaisedByUserId is required.");

            // Reason
            RuleFor(x => x.Reason)
                .MaximumLength(500).WithMessage("Reason must not exceed 500 characters.")
                .When(x => !string.IsNullOrEmpty(x.Reason));

            // AdminResolutionRemarks
            RuleFor(x => x.AdminResolutionRemarks)
                .MaximumLength(1000).WithMessage("Resolution remarks must not exceed 1000 characters.")
                .When(x => !string.IsNullOrEmpty(x.AdminResolutionRemarks));

            // Status
            RuleFor(x => x.Status)
                .IsInEnum().WithMessage("Invalid dispute status.");
        }
    }
}

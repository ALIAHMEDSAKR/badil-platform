using Badil.Domain.Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Common.Validators
{
    public class MessageValidator : BaseAuditableEntityValidator<Message>
    {
        public MessageValidator()
        {
            // SenderId
            RuleFor(x => x.SenderId)
                .NotEmpty().WithMessage("SenderId is required.");

            // ReceiverId
            RuleFor(x => x.ReceiverId)
                .NotEmpty().WithMessage("ReceiverId is required.");

            // Sender and Receiver must be different
            RuleFor(x => x)
                .Must(x => x.SenderId != x.ReceiverId)
                .WithMessage("Sender and Receiver cannot be the same user.");

            // Content
            RuleFor(x => x.Content)
                .NotEmpty().WithMessage("Message content is required.")
                .MaximumLength(2000).WithMessage("Message must not exceed 2000 characters.");
        }
    }
}

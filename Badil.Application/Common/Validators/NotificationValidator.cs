using Badil.Domain.Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Common.Validators
{
    public class NotificationValidator : BaseAuditableEntityValidator<Notification>
    {
        public NotificationValidator()
        {
            // UserId
            RuleFor(x => x.UserId)
                .NotEmpty().WithMessage("UserId is required.");

            // Content
            RuleFor(x => x.Content)
                .NotEmpty().WithMessage("Notification content is required.")
                .MaximumLength(500).WithMessage("Content must not exceed 500 characters.");

            // Type
            RuleFor(x => x.Type)
                .IsInEnum().WithMessage("Invalid notification type.");
        }
    }
}

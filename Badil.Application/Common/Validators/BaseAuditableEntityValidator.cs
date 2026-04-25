using Badil.Domain.Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Common.Validators
{
        public abstract class BaseAuditableEntityValidator<T> : AbstractValidator<T>
       where T : BaseAuditableEntity
        {
            protected BaseAuditableEntityValidator()
            {
                RuleFor(x => x.Id)
                    .NotEmpty()
                    .WithMessage("Id is required.");

                RuleFor(x => x.CreatedAt)
                    .NotEmpty().WithMessage("CreatedAt is required.")
                    .LessThanOrEqualTo(DateTime.UtcNow).WithMessage("CreatedAt cannot be in the future.");

                RuleFor(x => x.UpdatedAt)
                    .GreaterThanOrEqualTo(x => x.CreatedAt)
                    .WithMessage("UpdatedAt must be after CreatedAt.")
                    .When(x => x.UpdatedAt.HasValue);

                RuleFor(x => x.CreatedBy)
                    .NotEmpty()
                    .WithMessage("CreatedBy is required.");

                RuleFor(x => x.UpdatedBy)
                    .NotEmpty()
                    .WithMessage("UpdatedBy is required.")
                    .When(x => x.UpdatedAt.HasValue);
            }
        }
    }


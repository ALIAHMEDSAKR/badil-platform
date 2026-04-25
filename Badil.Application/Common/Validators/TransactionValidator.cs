using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Common.Validators
{
    public class TransactionValidator : BaseAuditableEntityValidator<Transaction>
    {
        public TransactionValidator()
        {
            // ListingId
            RuleFor(x => x.ListingId)
                .NotEmpty().WithMessage("ListingId is required.");

            // BuyerId
            RuleFor(x => x.BuyerId)
                .NotEmpty().WithMessage("BuyerId is required.");

            // SellerId
            RuleFor(x => x.SellerId)
                .NotEmpty().WithMessage("SellerId is required.");

            // Buyer and Seller must be different
            RuleFor(x => x)
                .Must(x => x.BuyerId != x.SellerId)
                .WithMessage("Buyer and Seller cannot be the same user.");

            // AgreedPrice
            RuleFor(x => x.AgreedPrice)
                .GreaterThan(0).WithMessage("Agreed price must be greater than 0.");

            // EscrowState
            RuleFor(x => x.EscrowState)
                .IsInEnum().WithMessage("Invalid escrow status.");
        }
    }
}

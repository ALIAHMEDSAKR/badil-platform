
using Badil.Domain.Enum;

namespace Badil.Domain.Entity
{
    public class Transaction : BaseAuditableEntity
    {
        public Guid ListingId { get; set; }
        public Guid BuyerId { get; set; }
        public Guid SellerId { get; set; }
        public decimal AgreedPrice { get; set; }
        public EscrowStatus EscrowState { get; set; }
        public bool IsSampleRequest { get; set; }
        public AppUser Buyer { get; set; }
        public AppUser Seller { get; set; }
        public WasteListing Listing { get; set; }
        public DisputeTicket DisputeTicket { get; set; }

        public void LockFunds() { }
        public void ConfirmDelivery() { }
        public void ReleaseFunds() { }
    }
}


using Badil.Domain.Enum;

namespace Badil.Domain.Entity
{
    public class DisputeTicket : BaseAuditableEntity
    {
        public Guid TransactionId { get; set; }
        public Guid RaisedByUserId { get; set; }
        public string Reason { get; set; }
        public DisputeStatus Status { get; set; }
        public string? AdminResolutionRemarks { get; set; }
        public Transaction Transaction { get; set; }

        public void Resolve(string? remarks) { }
    }



}

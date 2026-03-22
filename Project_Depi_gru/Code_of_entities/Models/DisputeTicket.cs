using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_of_entities.Models
{
    public enum DisputeStatus
    {
        Open,
        UnderInvestigation,
        Resolved
    }

    public class DisputeTicket : BaseAuditableEntity
    {
        public Guid TransactionId { get; set; }
        public Guid RaisedByUserId { get; set; }
        public string Reason { get; set; }
        public DisputeStatus Status { get; set; }
        public string AdminResolutionRemarks { get; set; }
    }
}

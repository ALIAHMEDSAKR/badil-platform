using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourProject.Domain.Entities.Models
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

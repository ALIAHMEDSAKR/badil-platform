using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourProject.Domain.Entities.Models
{
    public enum VerificationStatus
    {
        Pending,
        Approved,
        Rejected
    }

    public class VerificationRequest : BaseAuditableEntity
    {
        public Guid CompanyId { get; set; }
        public List<string> DocumentUrls { get; set; }
        public VerificationStatus Status { get; set; }
        public Guid? ReviewedByAdminId { get; set; }
    }
}

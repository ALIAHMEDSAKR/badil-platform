
using Badil.Domain.Enum;

namespace Badil.Domain.Entity
{
    public class VerificationRequest : BaseAuditableEntity
    {
        public Guid CompanyId { get; set; }
        public List<string> DocumentUrls { get; set; }
        public VerificationStatus Status { get; set; }
        public Guid? ReviewedByAdminId { get; set; }
        public Company Company { get; set; }

        public void Approve(Guid adminId) { }
        public void Reject(Guid adminId, string reason) { }
    }
}

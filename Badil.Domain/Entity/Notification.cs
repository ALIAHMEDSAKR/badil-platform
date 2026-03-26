
using Badil.Domain.Enum;

namespace Badil.Domain.Entity
{
    public class Notification : BaseAuditableEntity
    {
        public Guid UserId { get; set; }
        public string Content { get; set; }
        public NotificationType Type { get; set; }
        public bool IsRead { get; set; }
    }
}

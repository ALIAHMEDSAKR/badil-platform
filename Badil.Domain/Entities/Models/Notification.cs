using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourProject.Domain.Entities.Models
{
    public enum NotificationType
    {
        MatchFound,
        MessageReceived,
        TransactionUpdate,
        SystemAlert
    }

    public class Notification : BaseAuditableEntity
    {
        public Guid UserId { get; set; }
        public string Content { get; set; }
        public NotificationType Type { get; set; }
        public bool IsRead { get; set; }
    }
}

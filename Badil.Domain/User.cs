using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Domain.Models
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string FullName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public string CompanyName { get; set; } = string.Empty;

        public UserRole Role { get; set; } = UserRole.User;

        public VerificationStatus VerificationStatus { get; set; } = VerificationStatus.Pending;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public ICollection<Transaction> BuyerTransactions { get; set; } = [];
        public ICollection<Transaction> SellerTransactions { get; set; } = [];
        public ICollection<Message> SentMessages { get; set; } = [];
        public ICollection<Notification> Notifications { get; set; } = [];
        public ICollection<DisputeTicket> RaisedDisputes { get; set; } = [];
    }

}


using Badil.Domain.Enum;
using Badil.Domain.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.

namespace Badil.Domain.Entity
{
    public class AppUser : IdentityUser<Guid>, IAuditableEntity
    {
        // Idenitity => Email, PhoneNumber, Id, PasswordHash
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserRole Role { get; set; }
        public bool IsActive { get; set; }
        public Company Company { get; set; }
        public ICollection<MaterialRequest> MaterialRequests { get; set; } = new List<MaterialRequest>();
        public ICollection<WasteListing> WasteListings { get; set; } = new List<WasteListing>();
        public ICollection<Notification> Notifications { get; set; } = new List<Notification>();
        public ICollection<Message> SentMessages { get; set; } = new List<Message>();
        public ICollection<Message> ReceivedMessages { get; set; } = new List<Message>();
        public ICollection<Transaction> PurchasedTransactions { get; set; } = new List<Transaction>();
        public ICollection<Transaction> SoldTransactions { get; set; } = new List<Transaction>();
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }

        public void DeactivateAccount() { }

        public void UpdatePassword(string newHash) { }


    }
}


using Badil.Domain.Enum;

namespace Badil.Domain.Entity
{
    public class AppUser : BaseAuditableEntity
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string PasswordHash { get; set; }
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

        public void DeactivateAccount() { }

        public void UpdatePassword(string newHash) { }


    }
}


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


        public void DeactivateAccount() { }

        public void UpdatePassword(string newHash) { }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourProject.Domain.Entities.Models
{
    public enum UserRole
    {
        User,
        Admin
    }

    public class AppUser : BaseAuditableEntity
    {
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public UserRole Role { get; set; }
        public bool IsActive { get; set; }
    }
}

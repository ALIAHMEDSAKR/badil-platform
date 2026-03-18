using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_entity_abdelrahman
{
    public enum UserRole
    {
        seller, bayer, Admin
    }
    public class AppUser : BaseAuditableEntity
    {
        #region Attributes
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public UserRole Role { get; set; }
        public bool IsActive { get; set; }

        #endregion


    }
}



using Badil.Domain.Enum;

namespace Badil.Application.Features.Auth.DTOs
{
    public class RegisterRequest
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }    
        public string? PhoneNumber { get; set; }
        public UserRole Role { get; set; }

    }
}

using Badil.Domain.Entity;

namespace Badil.Application.Common.Interfaces
{
    public interface ITokenService
    {
        string GenerateJwtToken(AppUser user);
    }
}

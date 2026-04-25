using Badil.Application.Common.Interfaces.Repositories;
using Badil.Domain.Entity;
using Badil.Infrastructure.Data;



namespace Badil.Infrastructure.Repositories
{
    public class UserRepository : GenericRepository<AppUser> , IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context) { }
    }
}

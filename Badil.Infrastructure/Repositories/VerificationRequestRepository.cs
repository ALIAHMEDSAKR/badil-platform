using Badil.Application.Common.Interfaces.Repositories;
using Badil.Domain.Entity;
using Badil.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Badil.Infrastructure.Repositories
{
    public class VerificationRequestRepository : GenericRepository<VerificationRequest> , IVerificationRequestRepository
    {
        public VerificationRequestRepository(AppDbContext context) : base(context) {}       
    }
}

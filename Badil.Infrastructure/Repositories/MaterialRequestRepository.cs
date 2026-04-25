using Badil.Application.Common.Interfaces.Repositories;
using Badil.Domain.Entity;
using Badil.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Badil.Infrastructure.Repositories
{
    public class MaterialRequestRepository : GenericRepository<MaterialRequest> , IMaterialRequestRepository
    {
        public MaterialRequestRepository(AppDbContext context) : base(context) { }
    }
}

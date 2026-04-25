using Badil.Application.Common.Interfaces.Repositories;
using Badil.Domain.Entity;
using Badil.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;


namespace Badil.Infrastructure.Repositories
{
    public class ResourceMatchRepository : GenericRepository<ResourceMatch> , IResourceMatchRepository
    {
        public ResourceMatchRepository(AppDbContext context) : base(context) { }

    }
}

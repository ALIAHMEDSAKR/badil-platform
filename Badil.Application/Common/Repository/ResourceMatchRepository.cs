using Badil.Application.Common.Interfaces;
using Badil.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Common.Repository
{
    public class ResourceMatchRepository : IResourceMatchRepository
    {
        private readonly AppDbContext _context;
        public ResourceMatchRepository(AppDbContext context) => _context = context;

        public async Task<ResourceMatch?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
            => await _context.ResourceMatches.FindAsync(new object[] { id }, cancellationToken);

        public async Task<IReadOnlyList<ResourceMatch>> GetAllAsync(CancellationToken cancellationToken = default)
            => await _context.ResourceMatches.ToListAsync(cancellationToken);

        public async Task AddAsync(ResourceMatch match, CancellationToken cancellationToken = default)
        {
            await _context.ResourceMatches.AddAsync(match, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteAsync(ResourceMatch match, CancellationToken cancellationToken = default)
        {
            _context.ResourceMatches.Remove(match);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<bool> ExistsAsync(Guid id, CancellationToken cancellationToken = default)
            => await _context.ResourceMatches.AnyAsync(x => x.Id == id, cancellationToken);
    }
}

using Badil.Application.Common.Interfaces;
using Badil.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Common.Repository
{
    public class MaterialRequestRepository : IMaterialRequestRepository
    {
        private readonly AppDbContext _context;
        public MaterialRequestRepository(AppDbContext context) => _context = context;

        public async Task<MaterialRequest?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
            => await _context.MaterialRequests.FindAsync(new object[] { id }, cancellationToken);

        public async Task<IReadOnlyList<MaterialRequest>> GetAllAsync(CancellationToken cancellationToken = default)
            => await _context.MaterialRequests.ToListAsync(cancellationToken);

        public async Task AddAsync(MaterialRequest request, CancellationToken cancellationToken = default)
        {
            await _context.MaterialRequests.AddAsync(request, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteAsync(MaterialRequest request, CancellationToken cancellationToken = default)
        {
            _context.MaterialRequests.Remove(request);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<bool> ExistsAsync(Guid id, CancellationToken cancellationToken = default)
            => await _context.MaterialRequests.AnyAsync(x => x.Id == id, cancellationToken);
    }
}

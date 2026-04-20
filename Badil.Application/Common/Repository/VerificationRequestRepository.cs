using Badil.Application.Common.Interfaces;
using Badil.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Common.Repository
{
    public class VerificationRequestRepository : IVerificationRequestRepository
    {
        private readonly AppDbContext _context;
        public VerificationRequestRepository(AppDbContext context) => _context = context;

        public async Task<VerificationRequest?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
            => await _context.VerificationRequests.FindAsync(new object[] { id }, cancellationToken);

        public async Task<IReadOnlyList<VerificationRequest>> GetAllAsync(CancellationToken cancellationToken = default)
            => await _context.VerificationRequests.ToListAsync(cancellationToken);

        public async Task AddAsync(VerificationRequest request, CancellationToken cancellationToken = default)
        {
            await _context.VerificationRequests.AddAsync(request, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteAsync(VerificationRequest request, CancellationToken cancellationToken = default)
        {
            _context.VerificationRequests.Remove(request);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
    }

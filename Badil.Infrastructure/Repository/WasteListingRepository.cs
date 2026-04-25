using Badil.Application.Common.Interfaces;
using Badil.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Badil.Application.Common.Repository
{
    public class WasteListingRepository : IWasteListingRepository
    {
        private readonly AppDbContext _context; // Ensure AppDbContext is defined in your project

        public WasteListingRepository(AppDbContext context) => _context = context;

        public async Task<WasteListing?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
            => await _context.WasteListings.FindAsync(new object[] { id }, cancellationToken);

        public async Task<IReadOnlyList<WasteListing>> GetAllAsync(CancellationToken cancellationToken = default)
            => await _context.WasteListings.ToListAsync(cancellationToken);

        public async Task AddAsync(WasteListing listing, CancellationToken cancellationToken = default)
        {
            await _context.WasteListings.AddAsync(listing, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteAsync(WasteListing listing, CancellationToken cancellationToken = default)
        {
            _context.WasteListings.Remove(listing);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<bool> ExistsAsync(Guid id, CancellationToken cancellationToken = default)
            => await _context.WasteListings.AnyAsync(x => x.Id == id, cancellationToken);
    }
}

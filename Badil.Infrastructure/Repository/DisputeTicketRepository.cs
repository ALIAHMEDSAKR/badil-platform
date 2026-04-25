using Badil.Application.Common.Interfaces;
using Badil.Domain.Entity;
using Badil.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Common.Repository
{
    public class DisputeTicketRepository : IDisputeTicketRepository
    {
        private readonly AppDbContext _context;
        public DisputeTicketRepository(AppDbContext context) => _context = context;

        public async Task<DisputeTicket?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
            => await _context.DisputeTickets.FindAsync(new object[] { id }, cancellationToken);

        public async Task<IReadOnlyList<DisputeTicket>> GetAllAsync(CancellationToken cancellationToken = default)
            => await _context.DisputeTickets.ToListAsync(cancellationToken);

        public async Task AddAsync(DisputeTicket ticket, CancellationToken cancellationToken = default)
        {
            await _context.DisputeTickets.AddAsync(ticket, cancellationToken);
        }

        public async Task UpdateAsync(DisputeTicket ticket, CancellationToken cancellationToken = default)
        {
            _context.DisputeTickets.Update(ticket);
            await Task.CompletedTask;
        }

        public async Task DeleteAsync(DisputeTicket ticket, CancellationToken cancellationToken = default)
        {
            _context.DisputeTickets.Remove(ticket);
            await Task.CompletedTask;
        }

        public async Task<bool> ExistsAsync(Guid id, CancellationToken cancellationToken = default)
            => await _context.DisputeTickets.AnyAsync(x => x.Id == id, cancellationToken);

        public async Task SaveAsync(CancellationToken cancellationToken = default)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}

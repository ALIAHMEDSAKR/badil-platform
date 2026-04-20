using Badil.Application.Common.Interfaces;
using Badil.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Common.Repository
{
    public class MessageRepository : IMessageRepository
    {
        private readonly AppDbContext _context;
        public MessageRepository(AppDbContext context) => _context = context;

        public async Task<Message?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
            => await _context.Messages.FindAsync(new object[] { id }, cancellationToken);

        public async Task<IReadOnlyList<Message>> GetAllAsync(CancellationToken cancellationToken = default)
            => await _context.Messages.ToListAsync(cancellationToken);

        public async Task AddAsync(Message message, CancellationToken cancellationToken = default)
        {
            await _context.Messages.AddAsync(message, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteAsync(Message message, CancellationToken cancellationToken = default)
        {
            _context.Messages.Remove(message);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<bool> ExistsAsync(Guid id, CancellationToken cancellationToken = default)
            => await _context.Messages.AnyAsync(x => x.Id == id, cancellationToken);
    }
}

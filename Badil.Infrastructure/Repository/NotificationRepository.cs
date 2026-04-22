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
    public class NotificationRepository : INotificationRepository
    {
        private readonly AppDbContext _context;
        public NotificationRepository(AppDbContext context) => _context = context;

        public async Task<Notification?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
            => await _context.Notifications.FindAsync(new object[] { id }, cancellationToken);

        public async Task<IReadOnlyList<Notification>> GetAllAsync(CancellationToken cancellationToken = default)
            => await _context.Notifications.ToListAsync(cancellationToken);

        public async Task AddAsync(Notification notification, CancellationToken cancellationToken = default)
        {
            await _context.Notifications.AddAsync(notification, cancellationToken);
        }

        public async Task UpdateAsync(Notification notification, CancellationToken cancellationToken = default)
        {
            _context.Notifications.Update(notification);
            await Task.CompletedTask;
        }

        public async Task DeleteAsync(Notification notification, CancellationToken cancellationToken = default)
        {
            _context.Notifications.Remove(notification);
            await Task.CompletedTask;
        }

        public async Task<bool> ExistsAsync(Guid id, CancellationToken cancellationToken = default)
            => await _context.Notifications.AnyAsync(x => x.Id == id, cancellationToken);

        public async Task SaveAsync(CancellationToken cancellationToken = default)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}

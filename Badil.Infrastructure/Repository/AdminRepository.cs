using Badil.Application.Common.Interfaces;
using Badil.Domain.Entity;
using Badil.Domain.Enum;
using Badil.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Common.Repository
{
    public class AdminRepository : IAdminRepository
    {
        private readonly AppDbContext _context;

        public AdminRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<AppUser?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.Id == id && u.Role == UserRole.Admin, cancellationToken);
        }

        public async Task<IReadOnlyList<AppUser>> GetAllAdminsAsync(CancellationToken cancellationToken = default)
        {
            return await _context.Users
                .Where(u => u.Role == UserRole.Admin)
                .ToListAsync(cancellationToken);
        }

        public async Task AddAsync(AppUser admin, CancellationToken cancellationToken = default)
        {
            await _context.Users.AddAsync(admin, cancellationToken);
        }

        public async Task UpdateAsync(AppUser admin, CancellationToken cancellationToken = default)
        {
            _context.Users.Update(admin);
            await Task.CompletedTask;
        }

        public async Task DeleteAsync(AppUser admin, CancellationToken cancellationToken = default)
        {
            _context.Users.Remove(admin);
            await Task.CompletedTask;
        }

        public async Task<bool> ExistsAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await _context.Users
                .AnyAsync(u => u.Id == id && u.Role == UserRole.Admin, cancellationToken);
        }

        public async Task SaveAsync(CancellationToken cancellationToken = default)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}

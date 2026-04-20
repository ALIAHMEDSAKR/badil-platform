using Badil.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Common.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly AppDbContext _context;
        public TransactionRepository(AppDbContext context) => _context = context;

        public async Task<Transaction?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
            => await _context.Transactions.FindAsync(new object[] { id }, cancellationToken);

        public async Task<IReadOnlyList<Transaction>> GetAllAsync(CancellationToken cancellationToken = default)
            => await _context.Transactions.ToListAsync(cancellationToken);

        public async Task AddAsync(Transaction transaction, CancellationToken cancellationToken = default)
        {
            await _context.Transactions.AddAsync(transaction, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteAsync(Transaction transaction, CancellationToken cancellationToken = default)
        {
            _context.Transactions.Remove(transaction);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<bool> ExistsAsync(Guid id, CancellationToken cancellationToken = default)
            => await _context.Transactions.AnyAsync(x => x.Id == id, cancellationToken);
    }
}


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
    public class CompanyRepository : ICompanyRepository
    {
        private readonly AppDbContext _context;
        public CompanyRepository(AppDbContext context) => _context = context;

        public async Task<Company?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
            => await _context.Companies.FindAsync(new object[] { id }, cancellationToken);

        public async Task<IReadOnlyList<Company>> GetAllAsync(CancellationToken cancellationToken = default)
            => await _context.Companies.ToListAsync(cancellationToken);

        public async Task AddAsync(Company company, CancellationToken cancellationToken = default)
        {
            await _context.Companies.AddAsync(company, cancellationToken);
        }

        public async Task UpdateAsync(Company company, CancellationToken cancellationToken = default)
        {
            _context.Companies.Update(company);
            await Task.CompletedTask;
        }

        public async Task DeleteAsync(Company company, CancellationToken cancellationToken = default)
        {
            _context.Companies.Remove(company);
            await Task.CompletedTask;
        }

        public async Task<bool> ExistsAsync(Guid id, CancellationToken cancellationToken = default)
            => await _context.Companies.AnyAsync(x => x.Id == id, cancellationToken);

        public async Task SaveAsync(CancellationToken cancellationToken = default)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
    }

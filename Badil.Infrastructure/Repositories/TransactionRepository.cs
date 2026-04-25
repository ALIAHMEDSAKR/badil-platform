
using Badil.Application.Common.Interfaces.Repositories;
using Badil.Domain.Entity;
using Badil.Infrastructure.Data;


namespace Badil.Infrastructure.Repositories
{
    public class TransactionRepository : GenericRepository<Transaction> , ITransactionRepository
    {

        public TransactionRepository(AppDbContext context) : base(context) { }
    }
}


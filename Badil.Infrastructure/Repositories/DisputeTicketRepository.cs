using Badil.Application.Common.Interfaces.Repositories;
using Badil.Domain.Entity;
using Badil.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;


namespace Badil.Infrastructure.Repositories
{
    public class DisputeTicketRepository : GenericRepository<DisputeTicket> , IDisputeTicketRepository
    {
        public DisputeTicketRepository(AppDbContext context) : base(context) { }

     
    }
}

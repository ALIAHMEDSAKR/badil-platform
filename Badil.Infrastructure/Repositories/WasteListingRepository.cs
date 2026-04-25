using Badil.Application.Common.Interfaces.Repositories;
using Badil.Domain.Entity;
using Badil.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;



namespace Badil.Infrastructure.Repositories
{
    public class WasteListingRepository : GenericRepository<WasteListing> , IWasteListingRepository
    {
        public WasteListingRepository(AppDbContext context) : base(context) { }
       
    }
}

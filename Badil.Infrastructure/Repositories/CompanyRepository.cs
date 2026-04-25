using Badil.Application.Common.Interfaces.Repositories;
using Badil.Domain.Entity;
using Badil.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;


namespace Badil.Infrastructure.Repositories
{
    public class CompanyRepository : GenericRepository<Company> , ICompanyRepository
    {
        public CompanyRepository(AppDbContext context) : base(context) { }

    }
}

using Badil.Application.Common.Interfaces.Repositories;
using Badil.Domain.Entity;
using Badil.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;


namespace Badil.Infrastructure.Repositories
{
    public class MessageRepository : GenericRepository<Message> , IMessageRepository
    {
       
        public MessageRepository(AppDbContext context) : base(context) { }

       
    }
}

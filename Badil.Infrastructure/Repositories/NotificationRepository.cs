using Badil.Application.Common.Interfaces.Repositories;
using Badil.Domain.Entity;
using Badil.Infrastructure.Data;


namespace Badil.Infrastructure.Repositories
{
    public class NotificationRepository : GenericRepository<Notification> , INotificationRepository
    {
        public NotificationRepository(AppDbContext context) : base(context) { }

    }
}

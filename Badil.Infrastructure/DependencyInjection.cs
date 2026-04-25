
using Badil.Application.Common.Interfaces.Repositories;
using Badil.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Badil.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
           services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
           services.AddScoped<IUserRepository, UserRepository>();
           services.AddScoped<ICompanyRepository, CompanyRepository>();
           services.AddScoped<IMaterialRequestRepository, MaterialRequestRepository>();
           services.AddScoped<IMessageRepository, MessageRepository>();
           services.AddScoped<INotificationRepository, NotificationRepository>();
           services.AddScoped<IResourceMatchRepository, ResourceMatchRepository>();
           services.AddScoped<ITransactionRepository, TransactionRepository>();
           services.AddScoped<IDisputeTicketRepository, DisputeTicketRepository>();
           services.AddScoped<IVerificationRequestRepository, VerificationRequestRepository>();
           services.AddScoped<IWasteListingRepository, WasteListingRepository>();

            return services;
        }
    }
}

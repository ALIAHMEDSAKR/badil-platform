using Badil.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Common.Interfaces
{
    public interface IAdminRepository
    {
        Task<AppUser?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task<IReadOnlyList<AppUser>> GetAllAdminsAsync(CancellationToken cancellationToken = default);
        Task AddAsync(AppUser admin, CancellationToken cancellationToken = default);
        Task DeleteAsync(AppUser admin, CancellationToken cancellationToken = default);
        Task<bool> ExistsAsync(Guid id, CancellationToken cancellationToken = default);
    }

    public interface ICompanyRepository
    {
        Task<Company?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task<IReadOnlyList<Company>> GetAllAsync(CancellationToken cancellationToken = default);
        Task AddAsync(Company company, CancellationToken cancellationToken = default);
        Task DeleteAsync(Company company, CancellationToken cancellationToken = default);
        Task<bool> ExistsAsync(Guid id, CancellationToken cancellationToken = default);
    }

    public interface IMaterialRequestRepository
    {
        Task<MaterialRequest?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task<IReadOnlyList<MaterialRequest>> GetAllAsync(CancellationToken cancellationToken = default);
        Task AddAsync(MaterialRequest request, CancellationToken cancellationToken = default);
        Task DeleteAsync(MaterialRequest request, CancellationToken cancellationToken = default);
        Task<bool> ExistsAsync(Guid id, CancellationToken cancellationToken = default);
    }

    public interface IMessageRepository
    {
        Task<Message?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task<IReadOnlyList<Message>> GetAllAsync(CancellationToken cancellationToken = default);
        Task AddAsync(Message message, CancellationToken cancellationToken = default);
        Task DeleteAsync(Message message, CancellationToken cancellationToken = default);
        Task<bool> ExistsAsync(Guid id, CancellationToken cancellationToken = default);
    }

    public interface INotificationRepository
    {
        Task<Notification?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task<IReadOnlyList<Notification>> GetAllAsync(CancellationToken cancellationToken = default);
        Task AddAsync(Notification notification, CancellationToken cancellationToken = default);
        Task DeleteAsync(Notification notification, CancellationToken cancellationToken = default);
        Task<bool> ExistsAsync(Guid id, CancellationToken cancellationToken = default);
    }

    public interface IResourceMatchRepository
    {
        Task<ResourceMatch?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task<IReadOnlyList<ResourceMatch>> GetAllAsync(CancellationToken cancellationToken = default);
        Task AddAsync(ResourceMatch match, CancellationToken cancellationToken = default);
        Task DeleteAsync(ResourceMatch match, CancellationToken cancellationToken = default);
        Task<bool> ExistsAsync(Guid id, CancellationToken cancellationToken = default);
    }

    public interface ITransactionRepository
    {
        Task<Transaction?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task<IReadOnlyList<Transaction>> GetAllAsync(CancellationToken cancellationToken = default);
        Task AddAsync(Transaction transaction, CancellationToken cancellationToken = default);
        Task DeleteAsync(Transaction transaction, CancellationToken cancellationToken = default);
        Task<bool> ExistsAsync(Guid id, CancellationToken cancellationToken = default);
    }

    public interface IDisputeTicketRepository
    {
        Task<DisputeTicket?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task<IReadOnlyList<DisputeTicket>> GetAllAsync(CancellationToken cancellationToken = default);
        Task AddAsync(DisputeTicket ticket, CancellationToken cancellationToken = default);
        Task DeleteAsync(DisputeTicket ticket, CancellationToken cancellationToken = default);
        Task<bool> ExistsAsync(Guid id, CancellationToken cancellationToken = default);
    }

    public interface IVerificationRequestRepository
    {
        Task<VerificationRequest?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task<IReadOnlyList<VerificationRequest>> GetAllAsync(CancellationToken cancellationToken = default);
        Task AddAsync(VerificationRequest request, CancellationToken cancellationToken = default);
        Task DeleteAsync(VerificationRequest request, CancellationToken cancellationToken = default);
        Task<bool> ExistsAsync(Guid id, CancellationToken cancellationToken = default);
    }

    public interface IWasteListingRepository
    {
        Task<WasteListing?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task<IReadOnlyList<WasteListing>> GetAllAsync(CancellationToken cancellationToken = default);
        Task AddAsync(WasteListing listing, CancellationToken cancellationToken = default);
        Task DeleteAsync(WasteListing listing, CancellationToken cancellationToken = default);
        Task<bool> ExistsAsync(Guid id, CancellationToken cancellationToken = default);
    }
}

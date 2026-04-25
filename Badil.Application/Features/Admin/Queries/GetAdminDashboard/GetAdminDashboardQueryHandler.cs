using Badil.Application.Common.Interfaces.Repositories;
using Badil.Domain.Enum;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Features.Admin.Queries.GetAdminDashboard
{
    public class GetAdminDashboardQueryHandler
    : IRequestHandler<GetAdminDashboardQuery, AdminDashboardDto>
    {
        private readonly IUserRepository _userRepository;

        public GetAdminDashboardQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<AdminDashboardDto> Handle(
            GetAdminDashboardQuery request,
            CancellationToken cancellationToken)
        {
            var users = await _userRepository.GetAllAsync(cancellationToken);

            return new AdminDashboardDto
            {
                TotalUsers = users.Count,
                TotalAdmins = users.Count(u => u.Role == UserRole.Admin)
            };
        }
    }
}

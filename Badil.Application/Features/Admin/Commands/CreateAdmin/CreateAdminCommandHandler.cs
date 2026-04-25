using Badil.Application.Common.Interfaces.Repositories;
using Badil.Domain.Entity;
using Badil.Domain.Enum;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Features.Admin.Commands.CreateAdmin
{
    public class CreateAdminCommandHandler
    : IRequestHandler<CreateAdminCommand, Guid>
    {
        private readonly IUserRepository _userRepository;

        public CreateAdminCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        private readonly UserManager<AppUser> _userManager;

        public async Task<Guid> Handle(CreateAdminCommand request, CancellationToken cancellationToken)
        {
            var user = new AppUser
            {
                UserName = request.Email,
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Role = UserRole.Admin,
                IsActive = true
            };

            var result = await _userManager.CreateAsync(user, request.Password);

            if (!result.Succeeded)
                throw new Exception(string.Join(", ", result.Errors.Select(e => e.Description)));

            return user.Id;
        }
    }
}

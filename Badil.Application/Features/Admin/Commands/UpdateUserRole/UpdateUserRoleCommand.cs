using Badil.Domain.Enum;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Features.Admin.Commands.UpdateUserRole
{
    public class UpdateUserRoleCommand : IRequest
    {
        public Guid UserId { get; set; }
        public UserRole NewRole { get; set; }
    }
}

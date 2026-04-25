using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Features.Admin.Commands.DeleteUser
{
    public class DeleteUserCommand : IRequest
    {
        public Guid UserId { get; set; }
    }
}

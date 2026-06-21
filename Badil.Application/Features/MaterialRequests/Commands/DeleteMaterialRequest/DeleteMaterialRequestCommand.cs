using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Features.MaterialRequests.Commands.DeleteMaterialRequest
{
    public class DeleteMaterialRequestCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}

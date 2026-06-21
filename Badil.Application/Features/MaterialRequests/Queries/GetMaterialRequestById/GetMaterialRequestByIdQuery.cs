using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Features.MaterialRequests.Queries.GetMaterialRequestById
{
    public class GetMaterialRequestByIdQuery
    : IRequest<MaterialRequestDto?>
    {
        public Guid Id { get; set; }
    }
}

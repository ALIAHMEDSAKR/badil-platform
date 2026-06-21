using Badil.Application.Features.MaterialRequests.Queries.GetMaterialRequestById;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Features.MaterialRequests.Queries.GetAllMaterialRequests
{
    public class GetAllMaterialRequestsQuery
    : IRequest<IReadOnlyList<MaterialRequestDto>>
    {
    }
}

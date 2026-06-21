using Badil.Application.Common.Interfaces.Repositories;
using Badil.Application.Features.MaterialRequests.Queries.GetMaterialRequestById;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Features.MaterialRequests.Queries.GetAllMaterialRequests
{
    public class GetAllMaterialRequestsQueryHandler
    : IRequestHandler<GetAllMaterialRequestsQuery,
        IReadOnlyList<MaterialRequestDto>>
    {
        private readonly IMaterialRequestRepository _materialRequestRepository;

        public GetAllMaterialRequestsQueryHandler(
            IMaterialRequestRepository materialRequestRepository)
        {
            _materialRequestRepository = materialRequestRepository;
        }

        public async Task<IReadOnlyList<MaterialRequestDto>> Handle(
            GetAllMaterialRequestsQuery request,
            CancellationToken cancellationToken)
        {
            var requests =
                await _materialRequestRepository.GetAllAsync(
                    cancellationToken);

            return requests.Select(r => new MaterialRequestDto
            {
                Id = r.Id,
                UserId = r.UserId,
                MaterialType = r.MaterialType,
                TargetQuantity = r.TargetQuantity,
                LocationPreferenceRadiusKm =
                    r.LocationPreferenceRadiusKm
            }).ToList();
        }
    }
}

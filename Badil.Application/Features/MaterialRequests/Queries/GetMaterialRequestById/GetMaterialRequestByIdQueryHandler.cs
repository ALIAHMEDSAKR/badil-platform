using Badil.Application.Common.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Features.MaterialRequests.Queries.GetMaterialRequestById
{
    public class GetMaterialRequestByIdQueryHandler
    : IRequestHandler<GetMaterialRequestByIdQuery,
        MaterialRequestDto?>
    {
        private readonly IMaterialRequestRepository _materialRequestRepository;

        public GetMaterialRequestByIdQueryHandler(
            IMaterialRequestRepository materialRequestRepository)
        {
            _materialRequestRepository = materialRequestRepository;
        }

        public async Task<MaterialRequestDto?> Handle(
            GetMaterialRequestByIdQuery request,
            CancellationToken cancellationToken)
        {
            var materialRequest =
                await _materialRequestRepository.GetByIdAsync(
                    request.Id,
                    cancellationToken);

            if (materialRequest == null)
                return null;

            return new MaterialRequestDto
            {
                Id = materialRequest.Id,
                UserId = materialRequest.UserId,
                MaterialType = materialRequest.MaterialType,
                TargetQuantity = materialRequest.TargetQuantity,
                LocationPreferenceRadiusKm =
                    materialRequest.LocationPreferenceRadiusKm
            };
        }
    }
}

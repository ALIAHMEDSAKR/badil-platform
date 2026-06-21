using Badil.Application.Common.Interfaces.Repositories;
using Badil.Domain.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Features.MaterialRequests.Commands.CreateMaterialRequest
{
    public class CreateMaterialRequestCommandHandler
    : IRequestHandler<CreateMaterialRequestCommand, Guid>
    {
        private readonly IMaterialRequestRepository _materialRequestRepository;

        public CreateMaterialRequestCommandHandler(
            IMaterialRequestRepository materialRequestRepository)
        {
            _materialRequestRepository = materialRequestRepository;
        }

        public async Task<Guid> Handle(
            CreateMaterialRequestCommand request,
            CancellationToken cancellationToken)
        {
            var materialRequest = new MaterialRequest
            {
                UserId = request.UserId,
                MaterialType = request.MaterialType,
                TargetQuantity = request.TargetQuantity,
                LocationPreferenceRadiusKm = request.LocationPreferenceRadiusKm
            };

            await _materialRequestRepository.AddAsync(
                materialRequest,
                cancellationToken);

            return materialRequest.Id;
        }
    }
}

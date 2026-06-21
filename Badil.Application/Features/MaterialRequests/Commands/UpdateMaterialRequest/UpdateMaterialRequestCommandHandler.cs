using Badil.Application.Common.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Features.MaterialRequests.Commands.UpdateMaterialRequest
{
    public class UpdateMaterialRequestCommandHandler
    : IRequestHandler<UpdateMaterialRequestCommand>
    {
        private readonly IMaterialRequestRepository _materialRequestRepository;

        public UpdateMaterialRequestCommandHandler(
            IMaterialRequestRepository materialRequestRepository)
        {
            _materialRequestRepository = materialRequestRepository;
        }

        public async Task Handle(
            UpdateMaterialRequestCommand request,
            CancellationToken cancellationToken)
        {
            var materialRequest =
                await _materialRequestRepository.GetByIdAsync(
                    request.Id,
                    cancellationToken);

            if (materialRequest == null)
                throw new Exception("Material request not found.");

            materialRequest.MaterialType = request.MaterialType;
            materialRequest.TargetQuantity = request.TargetQuantity;
            materialRequest.LocationPreferenceRadiusKm =
                request.LocationPreferenceRadiusKm;

            await _materialRequestRepository.UpdateAsync(
                materialRequest,
                cancellationToken);
        }
    }
}

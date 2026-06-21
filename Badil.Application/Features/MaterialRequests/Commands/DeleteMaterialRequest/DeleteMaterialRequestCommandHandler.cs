using Badil.Application.Common.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Features.MaterialRequests.Commands.DeleteMaterialRequest
{
    public class DeleteMaterialRequestCommandHandler
     : IRequestHandler<DeleteMaterialRequestCommand>
    {
        private readonly IMaterialRequestRepository _materialRequestRepository;

        public DeleteMaterialRequestCommandHandler(
            IMaterialRequestRepository materialRequestRepository)
        {
            _materialRequestRepository = materialRequestRepository;
        }

        public async Task Handle(
            DeleteMaterialRequestCommand request,
            CancellationToken cancellationToken)
        {
            var materialRequest =
                await _materialRequestRepository.GetByIdAsync(
                    request.Id,
                    cancellationToken);

            if (materialRequest == null)
                throw new Exception("Material request not found.");

            await _materialRequestRepository.DeleteAsync(
                materialRequest,
                cancellationToken);
        }
    }
}

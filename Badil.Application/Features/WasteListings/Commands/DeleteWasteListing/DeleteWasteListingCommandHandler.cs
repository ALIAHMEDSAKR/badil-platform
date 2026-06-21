using Badil.Application.Common.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Features.WasteListings.Commands.DeleteWasteListing
{
    public class DeleteWasteListingCommandHandler
    : IRequestHandler<DeleteWasteListingCommand>
    {
        private readonly IWasteListingRepository _wasteListingRepository;

        public DeleteWasteListingCommandHandler(
            IWasteListingRepository wasteListingRepository)
        {
            _wasteListingRepository = wasteListingRepository;
        }

        public async Task Handle(
            DeleteWasteListingCommand request,
            CancellationToken cancellationToken)
        {
            var listing = await _wasteListingRepository.GetByIdAsync(
                request.Id,
                cancellationToken);

            if (listing == null)
                throw new Exception("Waste listing not found.");

            await _wasteListingRepository.DeleteAsync(
                listing,
                cancellationToken);

        }
    }
}

using Badil.Application.Common.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Features.WasteListings.Commands.ChangeWasteListingStatus
{
    public class ChangeWasteListingStatusCommandHandler
    : IRequestHandler<ChangeWasteListingStatusCommand>
    {
        private readonly IWasteListingRepository _wasteListingRepository;

        public ChangeWasteListingStatusCommandHandler(
            IWasteListingRepository wasteListingRepository)
        {
            _wasteListingRepository = wasteListingRepository;
        }

        public async Task Handle(
            ChangeWasteListingStatusCommand request,
            CancellationToken cancellationToken)
        {
            var listing = await _wasteListingRepository.GetByIdAsync(
                request.Id,
                cancellationToken);

            if (listing == null)
                throw new Exception("Waste listing not found.");

            listing.Status = request.Status;

            await _wasteListingRepository.UpdateAsync(
                listing,
                cancellationToken);

        }
    }
}

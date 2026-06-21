using Badil.Application.Common.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Features.WasteListings.Commands.UpdateWasteListing
{
    public class UpdateWasteListingCommandHandler
    : IRequestHandler<UpdateWasteListingCommand>
    {
        private readonly IWasteListingRepository _wasteListingRepository;

        public UpdateWasteListingCommandHandler(
            IWasteListingRepository wasteListingRepository)
        {
            _wasteListingRepository = wasteListingRepository;
        }

        public async Task Handle(
            UpdateWasteListingCommand request,
            CancellationToken cancellationToken)
        {
            var listing = await _wasteListingRepository.GetByIdAsync(
                request.Id,
                cancellationToken);

            if (listing == null)
                throw new Exception("Waste listing not found.");

            listing.MaterialType = request.MaterialType;
            listing.Quantity = request.Quantity;
            listing.Description = request.Description;
            listing.ImageUrls = request.ImageUrls;

            await _wasteListingRepository.UpdateAsync(
                listing,
                cancellationToken);

        }
    }
}

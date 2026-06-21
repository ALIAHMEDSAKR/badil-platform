using Badil.Application.Common.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Features.WasteListings.Queries.GetWasteListingById
{
    public class GetWasteListingByIdQueryHandler
    : IRequestHandler<GetWasteListingByIdQuery, WasteListingDto?>
    {
        private readonly IWasteListingRepository _wasteListingRepository;

        public GetWasteListingByIdQueryHandler(
            IWasteListingRepository wasteListingRepository)
        {
            _wasteListingRepository = wasteListingRepository;
        }

        public async Task<WasteListingDto?> Handle(
            GetWasteListingByIdQuery request,
            CancellationToken cancellationToken)
        {
            var listing = await _wasteListingRepository.GetByIdAsync(
                request.Id,
                cancellationToken);

            if (listing == null)
                return null;

            return new WasteListingDto
            {
                Id = listing.Id,
                UserId = listing.UserId,
                MaterialType = listing.MaterialType,
                Quantity = listing.Quantity,
                Description = listing.Description,
                ImageUrls = listing.ImageUrls,
                SuggestedPrice = listing.SuggestedPrice,
                Status = listing.Status
            };
        }
    }
}

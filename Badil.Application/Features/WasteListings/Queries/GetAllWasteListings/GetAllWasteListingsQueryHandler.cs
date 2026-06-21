using Badil.Application.Common.Interfaces.Repositories;
using Badil.Application.Features.WasteListings.Queries.GetWasteListingById;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Features.WasteListings.Queries.GetAllWasteListings
{
    public class GetAllWasteListingsQueryHandler
    : IRequestHandler<GetAllWasteListingsQuery,
        IReadOnlyList<WasteListingDto>>
    {
        private readonly IWasteListingRepository _wasteListingRepository;

        public GetAllWasteListingsQueryHandler(
            IWasteListingRepository wasteListingRepository)
        {
            _wasteListingRepository = wasteListingRepository;
        }

        public async Task<IReadOnlyList<WasteListingDto>> Handle(
            GetAllWasteListingsQuery request,
            CancellationToken cancellationToken)
        {
            var listings = await _wasteListingRepository.GetAllAsync(
                cancellationToken);

            return listings.Select(l => new WasteListingDto
            {
                Id = l.Id,
                UserId = l.UserId,
                MaterialType = l.MaterialType,
                Quantity = l.Quantity,
                Description = l.Description,
                ImageUrls = l.ImageUrls,
                SuggestedPrice = l.SuggestedPrice,
                Status = l.Status
            }).ToList();
        }
    }
}

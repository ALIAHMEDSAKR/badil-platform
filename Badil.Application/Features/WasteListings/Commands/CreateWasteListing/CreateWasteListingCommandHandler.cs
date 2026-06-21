using Badil.Application.Common.Interfaces.Repositories;
using Badil.Domain.Entity;
using Badil.Domain.Enum;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Features.WasteListings.Commands.CreateWasteListing
{
    public class CreateWasteListingCommandHandler
    : IRequestHandler<CreateWasteListingCommand, Guid>
    {
        private readonly IWasteListingRepository _wasteListingRepository;

        public CreateWasteListingCommandHandler(
            IWasteListingRepository wasteListingRepository)
        {
            _wasteListingRepository = wasteListingRepository;
        }

        public async Task<Guid> Handle(
            CreateWasteListingCommand request,
            CancellationToken cancellationToken)
        {
            var wasteListing = new WasteListing
            {
                UserId = request.UserId,
                MaterialType = request.MaterialType,
                Quantity = request.Quantity,
                Description = request.Description,
                ImageUrls = request.ImageUrls,

                Status = ListingStatus.Draft,

                IsVisuallyValidated = false,

                AIStandardizedTag = string.Empty,

                SuggestedPrice = 0
            };

            await _wasteListingRepository.AddAsync(
                wasteListing,
                cancellationToken);

            return wasteListing.Id;
        }
    }
}

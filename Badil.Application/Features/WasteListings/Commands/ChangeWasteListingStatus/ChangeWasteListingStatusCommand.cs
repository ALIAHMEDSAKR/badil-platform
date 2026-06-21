using Badil.Domain.Enum;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Features.WasteListings.Commands.ChangeWasteListingStatus
{
    public class ChangeWasteListingStatusCommand : IRequest
    {
        public Guid Id { get; set; }

        public ListingStatus Status { get; set; }
    }
}

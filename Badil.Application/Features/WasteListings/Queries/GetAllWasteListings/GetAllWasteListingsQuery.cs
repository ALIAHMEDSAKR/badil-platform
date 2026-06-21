using Badil.Application.Features.WasteListings.Queries.GetWasteListingById;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Features.WasteListings.Queries.GetAllWasteListings
{
    public class GetAllWasteListingsQuery
    : IRequest<IReadOnlyList<WasteListingDto>>
    {
    }
}

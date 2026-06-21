using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Features.WasteListings.Queries.GetWasteListingById
{
    public class GetWasteListingByIdQuery : IRequest<WasteListingDto?>
    {
        public Guid Id { get; set; }
    }
}

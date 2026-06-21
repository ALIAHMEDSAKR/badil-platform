using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Features.WasteListings.Commands.CreateWasteListing
{
    public class CreateWasteListingCommand : IRequest<Guid>
    {
        public Guid UserId { get; set; }

        public string MaterialType { get; set; }

        public double Quantity { get; set; }

        public string Description { get; set; }

        public List<string> ImageUrls { get; set; }
    }
}

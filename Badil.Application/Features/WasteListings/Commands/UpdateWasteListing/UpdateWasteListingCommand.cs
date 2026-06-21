using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Features.WasteListings.Commands.UpdateWasteListing
{
    public class UpdateWasteListingCommand : IRequest
    {
        public Guid Id { get; set; }

        public string MaterialType { get; set; }

        public double Quantity { get; set; }

        public string Description { get; set; }

        public List<string> ImageUrls { get; set; } = new();
    }
}

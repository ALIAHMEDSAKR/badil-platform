using Badil.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Features.WasteListings.Queries.GetWasteListingById
{
    public class WasteListingDto
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public string MaterialType { get; set; }

        public double Quantity { get; set; }

        public string Description { get; set; }

        public List<string> ImageUrls { get; set; }

        public decimal SuggestedPrice { get; set; }

        public ListingStatus Status { get; set; }
    }
}

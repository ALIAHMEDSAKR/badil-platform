using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_entity_abdelrahman
{
    public enum ListingStatus
    {
        Draft,
        Available,
        Sold
    }
    public class WasteListing : BaseAuditableEntity
    {
        public Guid SellerId { get; set; }
        public string MaterialType { get; set; }
        public string AIStandardizedTag { get; set; }
        public double Quantity { get; set; }
        public string Description { get; set; }
        public List<string> ImageUrls { get; set; }
        public decimal SuggestedPrice { get; set; }
        public ListingStatus Status { get; set; }
        public bool IsVisuallyValidated { get; set; }
    }
}

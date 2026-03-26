
using Badil.Domain.Enum;

namespace Badil.Domain.Entity
{
    public class WasteListing : BaseAuditableEntity
    {
        public Guid UserId { get; set; }
        public string MaterialType { get; set; }
        public string AIStandardizedTag { get; set; }
        public double Quantity { get; set; }
        public string Description { get; set; }
        public List<string> ImageUrls { get; set; }
        public decimal SuggestedPrice { get; set; }
        public ListingStatus Status { get; set; }
        public bool IsVisuallyValidated { get; set; }

        public void ApplyAITags(string[] tag) { } // is this an array ??
        public void MarkAsSold() { }
    }
}

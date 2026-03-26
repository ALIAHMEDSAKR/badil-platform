
namespace Badil.Domain.Entity
{
    public class ResourceMatch : BaseAuditableEntity
    {
        public Guid ListingId { get; set; }
        public Guid RequestId { get; set; }
        public double SemanticCompatibilityScore { get; set; }
        public double DistanceKm { get; set; }

        // public IsViableMatch(threshold) { } is ? : Bool RT
    }
}

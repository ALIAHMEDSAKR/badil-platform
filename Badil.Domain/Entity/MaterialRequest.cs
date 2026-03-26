
namespace Badil.Domain.Entity
{
    public class MaterialRequest : BaseAuditableEntity
    {
        public Guid UserId { get; set; }
        public string MaterialType { get; set; }
        public double TargetQuantity { get; set; }
        public double LocationPreferenceRadiusKm { get; set; }

        public void UpdateRequirements(double qty, double radius) {}

    }
}

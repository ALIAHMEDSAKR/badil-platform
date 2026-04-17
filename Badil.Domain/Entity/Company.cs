
namespace Badil.Domain.Entity
{
    public class Company : BaseAuditableEntity
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Sector { get; set; }
        public string Address { get; set; }
        public GeoLocation Location { get; set; }
        public bool IsVerified { get; set; }
        public string TaxRegistrationNumber { get; set; } //(رقم التسجيل الضريبي)
        public string CommercialRegisterNumber { get; set; } //(السجل التجاري)
        public AppUser Owner { get; set; }
        public ICollection<VerificationRequest> VerificationRequests { get; set; } = new List<VerificationRequest>();

        public void UpdateLocation(GeoLocation newLocation) { }
        public void MarkAsVerified() { }


    }
}

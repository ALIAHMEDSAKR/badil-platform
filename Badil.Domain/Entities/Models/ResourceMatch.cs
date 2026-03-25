using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourProject.Domain.Entities.Models
{
    public class ResourceMatch : BaseAuditableEntity
    {
        public Guid ListingId { get; set; }
        public Guid RequestId { get; set; }
        public double SemanticCompatibilityScore { get; set; }
        public double DistanceKm { get; set; }
    }
}

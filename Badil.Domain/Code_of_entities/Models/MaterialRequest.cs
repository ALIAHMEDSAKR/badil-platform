using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_of_entities.Models
{
    public class MaterialRequest : BaseAuditableEntity
    {
        public Guid BuyerId { get; set; }
        public string MaterialType { get; set; }
        public double TargetQuantity { get; set; }
        public double LocationPreferenceRadiusKm { get; set; }
    }
}

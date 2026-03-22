using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_of_entities.Models
{
    public class Company : BaseAuditableEntity
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Sector { get; set; }
        public string Address { get; set; }
        public GeoLocation Location { get; set; }
        public bool IsVerified { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourProject.Domain.Entities.Models
{
    

    public class Transaction : BaseAuditableEntity
    {
        public Guid ListingId { get; set; }
        public Guid BuyerId { get; set; }
        public Guid SellerId { get; set; }
        public decimal AgreedPrice { get; set; }
        public EscrowStatus EscrowState { get; set; }
        public bool IsSampleRequest { get; set; }
    }
}

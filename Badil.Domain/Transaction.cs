using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Domain.Models
{
    public class Transaction
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid ListingId { get; set; }

        public Guid BuyerId { get; set; }

        public Guid SellerId { get; set; }

        public decimal AgreedPrice { get; set; }
    }
}
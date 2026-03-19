using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Domain.Models
{
    public class Listing
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid SellerId { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public string Category { get; set; } = string.Empty;

        public ListingStatus Status { get; set; } = ListingStatus.Draft;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public User Seller { get; set; } = null!;
        public ICollection<Transaction> Transactions { get; set; } = [];
    }
}

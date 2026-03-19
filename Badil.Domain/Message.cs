using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Domain.Models
{
    public class Message
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid SenderId { get; set; }

        /// <summary>
        /// The recipient user — named UserId to align with the spec.
        /// </summary>
        public Guid UserId { get; set; }

        public string Content { get; set; } = string.Empty;

        public bool IsRead { get; set; } = false;

        public DateTime SentAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public User Sender { get; set; } = null!;
        public User Recipient { get; set; } = null!;
    }

}

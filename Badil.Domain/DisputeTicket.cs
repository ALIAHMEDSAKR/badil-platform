using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Domain.Models
{
    public class DisputeTicket
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid TransactionId { get; set; }

        public Guid RaisedByUserId { get; set; }

        public string Reason { get; set; } = string.Empty;
    }
    }

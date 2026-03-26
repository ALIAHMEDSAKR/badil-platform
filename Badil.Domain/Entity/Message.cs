
namespace Badil.Domain.Entity
{
    public class Message : BaseAuditableEntity
    {
        public Guid SenderId { get; set; }
        public Guid ReceiverId { get; set; }
        public string Content { get; set; }
        public bool IsRead { get; set; }
    }
}

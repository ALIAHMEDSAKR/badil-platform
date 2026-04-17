using Badil.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Badil.Domain.Data.Configurations
{
    public class DisputeTicketConfiguration : BaseAuditableEntityConfiguration<DisputeTicket>
    {
        public override void Configure(EntityTypeBuilder<DisputeTicket> builder)
        {
            base.Configure(builder);

            builder.Property(d => d.RaisedByUserId)
                .IsRequired();

            builder.Property(d => d.Reason)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(d => d.Status)
                .IsRequired()
                .HasConversion<string>() 
                .HasMaxLength(50);

            builder.Property(d => d.AdminResolutionRemarks)
                .HasMaxLength(1000);


            builder.HasOne(d => d.Transaction)
               .WithOne(t => t.DisputeTicket)
               .HasForeignKey<DisputeTicket>(d => d.TransactionId)
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(d => d.TransactionId);
            builder.HasIndex(d => d.RaisedByUserId);
            builder.HasIndex(d => d.Status);
        }
    }
}

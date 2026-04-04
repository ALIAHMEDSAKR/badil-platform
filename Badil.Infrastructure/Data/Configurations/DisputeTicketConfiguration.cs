using Badil.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Domain.Data.Configurations
{
    public class DisputeTicketConfiguration : IEntityTypeConfiguration<DisputeTicket>
    {
        public void Configure(EntityTypeBuilder<DisputeTicket> builder)
        {
            builder.HasKey(d => d.Id);

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

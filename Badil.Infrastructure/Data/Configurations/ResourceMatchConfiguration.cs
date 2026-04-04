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
    public class ResourceMatchConfiguration : IEntityTypeConfiguration<ResourceMatch>
    {
        public void Configure(EntityTypeBuilder<ResourceMatch> builder)
        {
            builder.HasKey(r => r.Id);

            builder.Property(r => r.SemanticCompatibilityScore)
                .IsRequired();

            builder.Property(r => r.DistanceKm)
                .IsRequired();

            builder.HasIndex(r => r.ListingId);
            builder.HasIndex(r => r.RequestId);

            builder.HasOne(r => r.Request)
                .WithMany(m => m.ResourceMatches)
                .HasForeignKey(r => r.RequestId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(r => r.Listing)
                   .WithMany(w => w.ResourceMatches)
                   .HasForeignKey(r => r.ListingId)
                   .OnDelete(DeleteBehavior.Cascade);

            // Optional: prevent duplicate matches between same listing & request
            builder.HasIndex(r => new { r.ListingId, r.RequestId })
                   .IsUnique();
        }
    }
}

using Badil.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Badil.Infrastructure.Data.Configurations
{
    public class ResourceMatchConfiguration : BaseAuditableEntityConfiguration<ResourceMatch>
    {
        public override void Configure(EntityTypeBuilder<ResourceMatch> builder)
        {
            base.Configure(builder);

            builder.Property(r => r.SemanticCompatibilityScore)
                .IsRequired();

            builder.Property(r => r.DistanceKm)
                .IsRequired();

            builder.HasIndex(r => r.ListingId);
            builder.HasIndex(r => r.RequestId);

            builder.HasOne(r => r.Request)
                .WithMany(m => m.ResourceMatches)
                .HasForeignKey(r => r.RequestId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(r => r.Listing)
                   .WithMany(w => w.ResourceMatches)
                   .HasForeignKey(r => r.ListingId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Optional: prevent duplicate matches between same listing & request
            builder.HasIndex(r => new { r.ListingId, r.RequestId })
                   .IsUnique();
        }
    }
}

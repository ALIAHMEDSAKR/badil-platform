using Badil.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Badil.Domain.Data.Configurations
{
    public class MaterialRequestConfiguration : BaseAuditableEntityConfiguration<MaterialRequest>
    {
        public override void Configure(EntityTypeBuilder<MaterialRequest> builder)
        {
            base.Configure(builder);

            builder.Property(m => m.MaterialType)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(m => m.TargetQuantity)
                .IsRequired();

            builder.Property(m => m.LocationPreferenceRadiusKm)
                .IsRequired();

            builder.HasOne(m => m.User)
            .WithMany(u => u.MaterialRequests)
            .HasForeignKey(m => m.UserId)
            .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(m => m.UserId);
            builder.HasIndex(m => m.MaterialType);
        }
    }
}

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
    public class MaterialRequestConfiguration : IEntityTypeConfiguration<MaterialRequest>
    {
        public void Configure(EntityTypeBuilder<MaterialRequest> builder)
        {
            builder.HasKey(m => m.Id);

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

using Badil.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.Json;


namespace Badil.Domain.Data.Configurations
{
    public class VerificationRequestConfiguration : BaseAuditableEntityConfiguration<VerificationRequest>
    {
        public override void Configure(EntityTypeBuilder<VerificationRequest> builder)
        {
            base.Configure(builder);

            // Convert List<string> to JSON
            builder.Property(v => v.DocumentUrls)
                   .HasConversion(
                        v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                        v => JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions)null))
                   .HasColumnType("nvarchar(max)")
                   .IsRequired();

            builder.Property(v => v.Status)
                   .HasConversion<string>()
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(v => v.ReviewedByAdminId);

            builder.HasOne(v => v.Company)
            .WithMany(c => c.VerificationRequests)
            .HasForeignKey(v => v.CompanyId)
            .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(v => v.CompanyId);
            builder.HasIndex(v => v.ReviewedByAdminId);
        }
    }
}

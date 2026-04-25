using Badil.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.Json;



namespace Badil.Infrastructure.Data.Configurations
{
    public class WasteListingConfiguration : BaseAuditableEntityConfiguration<WasteListing>
    {
        public override void Configure(EntityTypeBuilder<WasteListing> builder)
        {
            base.Configure(builder);

            builder.Property(w => w.MaterialType)
                   .IsRequired()
                   .HasMaxLength(150);

            builder.Property(w => w.AIStandardizedTag)
                   .HasMaxLength(150);

            builder.Property(w => w.Quantity).IsRequired();
            builder.Property(w => w.Description)
                   .HasMaxLength(1000);

            // Convert List<string> to JSON
            builder.Property(w => w.ImageUrls)
                   .IsRequired()
                   .HasConversion(
                        v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                        v => JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions)null)!)
                   .HasColumnType("nvarchar(max)");

            builder.Property(w => w.SuggestedPrice)
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(w => w.Status)
                   .HasConversion<string>()
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(w => w.IsVisuallyValidated)
                   .HasDefaultValue(false);


            builder.HasOne(w => w.User)
            .WithMany(u => u.WasteListings)
            .HasForeignKey(w => w.UserId)
            .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(w => w.UserId);
            builder.HasIndex(w => w.MaterialType);
        }
    }
}

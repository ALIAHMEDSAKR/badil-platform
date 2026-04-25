
using Badil.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Badil.Infrastructure.Data.Configurations
{
    public class CompanyConfiguration : BaseAuditableEntityConfiguration<Company>
    {
        public override void Configure(EntityTypeBuilder<Company> builder)
        {
            base.Configure(builder);

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(c => c.Sector)
                .HasMaxLength(100);

            builder.Property(c => c.Address)
                .HasMaxLength(300);

            builder.Property(c => c.IsVerified)
                .HasDefaultValue(false);

            builder.Property(c => c.TaxRegistrationNumber)
                .HasMaxLength(100);

            builder.Property(c => c.CommercialRegisterNumber)
                .HasMaxLength(100);

            builder.OwnsOne(c => c.Location, location =>
            {
                location.Property(l => l.Latitude)
                    .HasColumnName("Latitude")
                    .IsRequired();

                location.Property(l => l.Longitude)
                    .HasColumnName("Longitude")
                    .IsRequired();
            });

            builder.HasOne(c => c.Owner)
            .WithOne(u => u.Company)
            .HasForeignKey<Company>(c => c.UserId)
            .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(c => c.UserId);
            builder.HasIndex(c => c.Name);
        }
    }
}

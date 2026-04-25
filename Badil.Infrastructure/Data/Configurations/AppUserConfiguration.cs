using Badil.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Badil.Domain.Data.Configurations
{
    public class AppUserConfiguration : BaseAuditableEntityConfiguration<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            base.Configure(builder);

            //builder.Property((au) => au.Email)
            //       .IsRequired()
            //       .HasMaxLength(256);

            builder.Property((au) => au.FirstName)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property((au) => au.LastName)
                   .IsRequired()
                   .HasMaxLength(100);

            //builder.Property((au) => au.PhoneNumber)
            //       .HasMaxLength(20);

            //builder.Property((au) => au.PasswordHash)
            //       .IsRequired();

            builder.Property((au) => au.Role)
                   .IsRequired()
                   .HasConversion<string>(); 

            builder.Property((au) => au.IsActive)
                   .IsRequired()
                   .HasDefaultValue(false);
        }
    }
}

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
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            {
                builder.HasKey((au) => au.Id);

                builder.Property((au) => au.Email)
                       .IsRequired()
                       .HasMaxLength(256);

                builder.Property((au) => au.FirstName)
                       .IsRequired()
                       .HasMaxLength(100);

                builder.Property((au) => au.LastName)
                       .IsRequired()
                       .HasMaxLength(100);

                builder.Property((au) => au.PhoneNumber)
                       .HasMaxLength(20);

                builder.Property((au) => au.PasswordHash)
                       .IsRequired();

                builder.Property((au) => au.Role)
                       .IsRequired()
                       .HasConversion<string>(); 

                builder.Property((au) => au.IsActive)
                       .IsRequired()
                       .HasDefaultValue(false);
            }
        }
    }
}

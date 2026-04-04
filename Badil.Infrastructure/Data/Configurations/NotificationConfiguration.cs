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
    public class NotificationConfiguration : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder.HasKey(n => n.Id);

            builder.Property(n => n.Content)
                .IsRequired()
                .HasMaxLength(1000);

            builder.Property(n => n.Type)
                .IsRequired()
                .HasConversion<string>()
                .HasMaxLength(50);

            builder.Property(n => n.IsRead)
                .HasDefaultValue(false);

            builder.HasOne(n => n.User)
            .WithMany(u => u.Notifications)
            .HasForeignKey(n => n.UserId)
            .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(n => n.UserId);
            builder.HasIndex(n => n.Type);
        }
    }
}

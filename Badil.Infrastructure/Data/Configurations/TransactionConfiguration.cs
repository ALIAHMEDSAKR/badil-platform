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
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.AgreedPrice)
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(t => t.EscrowState)
                .HasConversion<string>()
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(t => t.IsSampleRequest)
                .HasDefaultValue(false);


            builder.HasOne(t => t.Listing)
               .WithOne(w => w.Transaction)
               .HasForeignKey<Transaction>(t => t.ListingId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.Buyer)
               .WithMany(u => u.PurchasedTransactions)
               .HasForeignKey(t => t.BuyerId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.Seller)
                .WithMany(u => u.SoldTransactions)
                .HasForeignKey(t => t.SellerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(t => t.ListingId);
            builder.HasIndex(t => t.BuyerId);
            builder.HasIndex(t => t.SellerId);
        }
    }
}

using Badil.Domain.Entity;
using Badil.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Badil.Domain.Data.Configurations
{
    public abstract class BaseAuditableEntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : class , IAuditableEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey((bae) => bae.Id);

            builder.Property((bae) => bae.Id)
                   .ValueGeneratedOnAdd(); 

            builder.Property((bae) => bae.CreatedAt)
                   .IsRequired()
                   .ValueGeneratedNever();

            builder.Property((bae) => bae.UpdatedAt);

            builder.Property((bae) => bae.CreatedBy)
                   .IsRequired();

            builder.Property((bae) => bae.UpdatedBy);
        }
    }
}

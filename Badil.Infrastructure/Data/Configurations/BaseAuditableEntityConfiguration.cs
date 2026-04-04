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
    public class BaseAuditableEntityConfiguration: IEntityTypeConfiguration<BaseAuditableEntity>
    {
        public void Configure(EntityTypeBuilder<BaseAuditableEntity> builder)
        {
            builder.HasKey((bae) => bae.Id);

            builder.Property((bae) => bae.Id)
                   .ValueGeneratedNever(); 

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

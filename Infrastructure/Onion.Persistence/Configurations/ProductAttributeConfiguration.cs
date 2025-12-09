using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Onion.Domain.Entities;

namespace Onion.Persistence.Configurations
{
    public class ProductAttributeConfiguration : BaseConfiguration<ProductAttribute>
    {
        public override void Configure(EntityTypeBuilder<ProductAttribute> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.AttributeName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.AttributeType)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.Description)
                .HasMaxLength(500);

            builder.Property(x => x.ValidationRule)
                .HasMaxLength(500);

            builder.HasIndex(x => x.AttributeName)
                .IsUnique();
        }
    }
}

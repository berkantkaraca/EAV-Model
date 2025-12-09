using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Onion.Domain.Entities;

namespace Onion.Persistence.Configurations
{
    public class ProductAttributeValueConfiguration : BaseConfiguration<ProductAttributeValue>
    {
        public override void Configure(EntityTypeBuilder<ProductAttributeValue> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.AttributeValue)
                .IsRequired()
                .HasMaxLength(1000);

            // Foreign Keys
            builder.HasOne(x => x.Product)
                .WithMany(x => x.ProductAttributeValues)
                .HasForeignKey(x => x.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.ProductAttribute)
                .WithMany(x => x.ProductAttributeValues)
                .HasForeignKey(x => x.ProductAttributeId)
                .OnDelete(DeleteBehavior.Restrict);

            // Composite Index - Bir ürün için aynı öznitelik bir kez olmalı
            builder.HasIndex(x => new { x.ProductId, x.ProductAttributeId })
                .IsUnique();
        }
    }
}

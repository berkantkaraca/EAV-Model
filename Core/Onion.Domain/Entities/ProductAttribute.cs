namespace Onion.Domain.Entities
{
    public class ProductAttribute : BaseEntity
    {
        public string AttributeName { get; set; }
        public string AttributeType { get; set; } // String, Number, Boolean, Date, etc.
        public string? Description { get; set; }
        public bool IsRequired { get; set; }
        public string? ValidationRule { get; set; }

        // Relational Properties
        public virtual ICollection<ProductAttributeValue> ProductAttributeValues { get; set; }
    }
}

using Database.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        string table = "product";
        builder.ToTable(table);
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).HasColumnName("product_id");
        builder.Property(e => e.Name).HasColumnName("name");
        builder.Property(e => e.Quantity).HasColumnName("quantity");
        builder.Property(e => e.Price).HasColumnName("price");
        builder.Property(e => e.Description).HasColumnName("description");
        builder.Property(e => e.ImageUrl).HasColumnName("image_url");
        builder.Property(e => e.CreatedAt).HasColumnName("created_at");
        builder.Property(e => e.UpdatedAt).HasColumnName("updated_at");
    }
}
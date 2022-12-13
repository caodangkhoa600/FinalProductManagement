using Database.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations;

public class ProductImportConfiguration : IEntityTypeConfiguration<ProductImportRecord>
{
    public void Configure(EntityTypeBuilder<ProductImportRecord> builder)
    {
        string table = "product_import";
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).HasColumnName("product_import_id");
        builder.Property(e => e.ProductId).HasColumnName("product_id");
        builder.Property(e => e.Quantity).HasColumnName("quantity");
        builder.Property(e => e.CreatedAt).HasColumnName("created_at");
        builder.Property(e => e.UpdatedAt).HasColumnName("updated_at");
    }
}
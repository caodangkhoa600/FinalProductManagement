using Database.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations;

public class CartConfiguration : IEntityTypeConfiguration<Cart>
{
    public void Configure(EntityTypeBuilder<Cart> builder)
    {
        string table = "cart";
        builder.ToTable(table);
        builder.HasKey(e => new {e.Email, e.ProductId});
        builder.Property(e => e.ProductId).HasColumnName("product_id");
        builder.Property(e => e.Email).HasColumnName("email");
        builder.Property(e => e.Quantity).HasColumnName("quantity");
        builder.Ignore(e => e.Id);
    }
}
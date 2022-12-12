using Database.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        string table = "order";
        builder.ToTable(table);
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).HasColumnName("order_id");
        builder.Property(e => e.PaymentType).HasColumnName("payment_type");
        builder.Property(e => e.PaymentStatus).HasColumnName("payment_status");
        builder.Property(e => e.OrderStatus).HasColumnName("order_status");
        builder.Property(e => e.TotalPrice).HasColumnName("total_price");
        builder.Property(e => e.Email).HasColumnName("email");
        builder.Property(e => e.ShippingCost).HasColumnName("shipping_cost");
        builder.Property(e => e.Address).HasColumnName("address");
        builder.Property(e => e.CreatedAt).HasColumnName("created_at");
        builder.Property(e => e.UpdatedAt).HasColumnName("updated_at");
    }
}
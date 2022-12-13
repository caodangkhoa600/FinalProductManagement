using Database.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations;

public class AccountConfiguration : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        string table = "account";
        builder.HasKey(e => e.Email);
        builder.Property(e => e.Username).HasColumnName("username");
        builder.Property(e => e.Address).HasColumnName("address");
        builder.Property(e => e.Email).HasColumnName("email");
        builder.Property(e => e.Password).HasColumnName("password");
        builder.Property(e => e.Type).HasColumnName("type");
        builder.Property(e => e.Name).HasColumnName("name");
        builder.Property(e => e.CreatedAt).HasColumnName("created_at");
        builder.Property(e => e.UpdatedAt).HasColumnName("updated_at");

        builder.Ignore(e => e.Id);
    }
}
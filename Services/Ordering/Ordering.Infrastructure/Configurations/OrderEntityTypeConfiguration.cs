using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ordering.Domain.Entities;
using Ordering.Infrastructure.Persistence;

namespace Ordering.Infrastructure.Configurations
{
    public class OrderEntityTypeConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Order", OrderContext.DefaultSchema);

            builder.HasKey(o => o.Id);

            builder.HasIndex(o => o.UserName)
                .IsUnique(false);

            builder.Property(o => o.TotalPrice)
                .IsRequired();

            builder.Property(o => o.ShippingAddress)
                .IsRequired();

            builder.HasMany(o => o.Items)
                .WithOne(oi => oi.Order);
        }
    }
}

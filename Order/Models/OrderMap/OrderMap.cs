using BillingAddress.Models;
using Microsoft.EntityFrameworkCore;
using Order.Models;

namespace Order.Models
{
    public class OrderMap : IEntityTypeConfiguration<OrderModel>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<OrderModel> builder)
        {
            builder.ToTable("Order");
            builder.HasKey(e => e.OrderId);
            builder.Property(e => e.OrderId).UseIdentityColumn().IsRequired(true).HasColumnType("int").ValueGeneratedOnAdd();
            builder.Property(e => e.TrackerCode).HasMaxLength(6).IsRequired(true);
            builder.Property(e => e.TotalPrice).HasMaxLength(11).IsRequired(true);
            builder.Property(e => e.PaymentType).HasMaxLength(15).IsRequired(true);
            builder.Property(e => e.IsActive).IsRequired(true);
            builder.Property(e => e.CreatedTime).IsRequired(true);
            builder.Property(e => e.CreatedUserId).HasMaxLength(50).IsRequired(true);
            builder.Property(e => e.ModifiedTime).IsRequired(true);
            builder.Property(e => e.ModifiedUserId).IsRequired(true).HasMaxLength(50);
            builder.Property(e => e.DeletedTime).IsRequired(true);
            builder.Property(e => e.DeletedUserId).IsRequired(true);
            builder.HasOne<ItemModel>(e => e.Item).WithMany(c => c.Order).HasForeignKey(e => e.ItemId);
            builder.HasOne<PayOnDeliveryModel>(e => e.PayOnDelivery).WithMany(c => c.Order).HasForeignKey(e => e.PayOnDeliveryId)/*.HasPrincipalKey(sc => sc.PayOnDeliveryId)*/;
            builder.HasOne<BillingAddressModel>(e => e.BillingAddress).WithMany(c => c.Order).HasForeignKey(e => e.BillingAddressId);
            builder.HasOne<CustomerModel>(e => e.Customer).WithMany(c => c.Order).HasForeignKey(e => e.CustomerId);
                //Lamda expression
        }
     }
}

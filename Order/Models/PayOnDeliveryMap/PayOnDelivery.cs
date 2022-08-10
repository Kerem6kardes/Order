using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Order.Models;

namespace Payment.Models
{
    public class PayOnDeliveryMap : IEntityTypeConfiguration<PayOnDeliveryModel>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<PayOnDeliveryModel> builder)
        {
            builder.HasKey(e => e.PayOnDeliveryId);
            builder.Property(e => e.PayOnDeliveryId).IsRequired(true).HasColumnType("int").UseIdentityColumn().ValueGeneratedOnAdd();
            builder.Property(e => e.PaymentAmount).HasMaxLength(11).IsRequired(true);
            builder.Property(e => e.IsActive).IsRequired(true);
            builder.Property(e => e.CreatedTime).IsRequired(true);
            builder.Property(e => e.CreatedUserId).HasMaxLength(50).IsRequired(true);
            builder.Property(e => e.ModifiedTime).IsRequired(true);
            builder.Property(e => e.ModifiedUserId).IsRequired(true).HasMaxLength(50);
            builder.Property(e => e.DeletedTime).IsRequired(true);
            builder.Property(e => e.DeletedUserId).IsRequired(true);
            builder.ToTable("PayOnDelivery");
        }       
    }
}

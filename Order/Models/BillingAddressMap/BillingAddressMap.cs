using BillingAddress.Models;
using Microsoft.EntityFrameworkCore;
using Order.Models;

namespace BillingAddress.Models.BillingAddressMap
{
    public class BillingAddressMap : IEntityTypeConfiguration<BillingAddressModel>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<BillingAddressModel> builder)
        {
            builder.ToTable("BillingAddress");
            builder.HasKey(c => c.BillingAddressId);
            builder.Property(c => c.BillingAddressId).UseIdentityColumn().IsRequired(true).HasColumnType("int").ValueGeneratedOnAdd();
            builder.Property(c => c.BillingAddressType).HasMaxLength(10).IsRequired(true);
            builder.Property(c => c.IsActive).IsRequired(true);
            builder.Property(c => c.CreatedTime).IsRequired(true);
            builder.Property(c => c.CreatedUserId).HasMaxLength(50).IsRequired(true);
            builder.Property(c => c.ModifiedTime).IsRequired(true);
            builder.Property(c => c.ModifiedUserId).IsRequired(true).HasMaxLength(50);
            builder.Property(c => c.DeletedTime).IsRequired(true);
            builder.Property(c => c.DeletedUserId).IsRequired(true);
            builder.HasOne<CityModel>(e => e.City).WithMany(c => c.BillingAddress).HasForeignKey(e => e.CityId);
            //builder.HasOne<OrderModel>(c => c.Order).WithMany(e => e.BillingAddress.).HasForeignKey(e => e.OrderId);
        }
    }
}

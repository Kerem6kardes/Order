using Microsoft.EntityFrameworkCore;
using Order.Models;

namespace Customer.Model.CustomerMap
{
    public class CustomerMap : IEntityTypeConfiguration<CustomerModel>
    {
        void IEntityTypeConfiguration<CustomerModel>.Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CustomerModel> builder)
        {
            builder.HasKey(c => c.CustomerId);
            builder.Property(c => c.CustomerId).UseIdentityColumn().IsRequired(true).HasColumnType("int").ValueGeneratedOnAdd();
            builder.Property(c => c.CustomerFirstName).HasMaxLength(30).IsRequired(true);
            builder.Property(c => c.CustomerLastName).HasMaxLength(30).IsRequired(true);
            builder.Property(c => c.PhoneNumber).HasMaxLength(30).IsRequired(true);
            builder.Property(c => c.EmailAllowed).HasMaxLength(11).IsRequired(true);
            builder.Property(c => c.EmailAddress).HasMaxLength(30).IsRequired(true);
            builder.Property(c => c.IsActive).IsRequired(true);
            builder.Property(c => c.CreatedTime).IsRequired(true);
            builder.Property(c => c.CreatedUserId).HasMaxLength(50).IsRequired(true);
            builder.Property(c => c.ModifiedTime).IsRequired(true);
            builder.Property(c => c.ModifiedUserId).IsRequired(true).HasMaxLength(50);
            builder.Property(c => c.DeletedTime).IsRequired(true);
            builder.Property(c => c.DeletedUserId).IsRequired(true);
            builder.ToTable("Customer");
            //builder.HasMany<OrderModel>(e => e.Order).WithOne(o => o.Customer).HasForeignKey(e => e.OrderId);//.HasPrincipalKey(sc => sc.CustomerId);
        }
    }
}

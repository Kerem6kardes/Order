using Microsoft.EntityFrameworkCore;
using Order.Models;

namespace Order.Models
{
    public class CityMap : IEntityTypeConfiguration<CityModel>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CityModel> builder)
        {
            builder.ToTable("City");
            builder.HasKey(e => e.CityId);
            builder.Property(e => e.CityId).UseIdentityColumn().IsRequired(true).HasColumnType("int").ValueGeneratedOnAdd();
            builder.Property(e => e.CityName).HasMaxLength(15).IsRequired(true);
            builder.Property(e => e.IsActive).IsRequired(true);
            builder.Property(e => e.CreatedTime).IsRequired(true);
            builder.Property(e => e.CreatedUserId).HasMaxLength(50).IsRequired(true);
            builder.Property(e => e.ModifiedTime).IsRequired(true);
            builder.Property(e => e.ModifiedUserId).IsRequired(true).HasMaxLength(50);
            builder.Property(e => e.DeletedTime).IsRequired(true);
            builder.Property(e => e.DeletedUserId).IsRequired(true);
            //builder.HasOne<BillingAddressModel>(e => e.BillingAddress).WithMany(c => c.City).HasForeignKey(e => e.BillingAddressId);
        }
    }
}
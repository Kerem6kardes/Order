using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Order.Models;

namespace Item.Models
{
    public class ItemMap : IEntityTypeConfiguration<ItemModel>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ItemModel> builder)
        {
            builder.HasKey(e => e.ItemId);
            builder.Property(e => e.ItemId).UseIdentityColumn().IsRequired(true).HasColumnType("int").ValueGeneratedOnAdd();
            builder.Property(e => e.ItemName).HasMaxLength(30).IsRequired(true);
            builder.Property(e => e.Price).HasMaxLength(11).IsRequired(true);
            builder.Property(e => e.Barcode).HasMaxLength(12).IsRequired(true);
            builder.Property(e => e.IsActive).IsRequired(true);
            builder.Property(e => e.CreatedTime).IsRequired(true);
            builder.Property(e => e.CreatedUserId).HasMaxLength(50).IsRequired(true);
            builder.Property(e => e.ModifiedTime).IsRequired(true);
            builder.Property(e => e.ModifiedUserId).IsRequired(true).HasMaxLength(50);
            builder.Property(e => e.DeletedTime).IsRequired(true);
            builder.Property(e => e.DeletedUserId).IsRequired(true);
            builder.ToTable("Item");

        }
    }
}

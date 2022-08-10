using BillingAddress.Models.BillingAddressMap;
using Customer.Model.CustomerMap;
using Item.Models;
using Microsoft.EntityFrameworkCore;
using Payment.Models;
using BillingAddress.Models;

namespace Order.Models
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options)
        {
         
        }
        public DbSet<OrderModel> Order { get; set; }
        public DbSet<CustomerModel>Customer { get; set; }
        public DbSet<ItemModel>Item { get; set; }
        public DbSet<PayOnDeliveryModel>PayOnDelivery { get; set; }
        public DbSet<BillingAddressModel>BillingAddress { get; set; }
        public DbSet<CityModel> City { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             modelBuilder = modelBuilder.ApplyConfiguration(new OrderMap());
             modelBuilder = modelBuilder.ApplyConfiguration(new ItemMap());
             modelBuilder = modelBuilder.ApplyConfiguration(new CustomerMap());
             modelBuilder = modelBuilder.ApplyConfiguration(new PayOnDeliveryMap());
             modelBuilder = modelBuilder.ApplyConfiguration(new CityMap());
             modelBuilder = modelBuilder.ApplyConfiguration(new BillingAddressMap());
            
        }
    }
}

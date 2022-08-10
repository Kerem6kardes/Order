using BillingAddress.Models;
using my_orders.Data.ViewModels;
using Order.Models;
using System.Collections.Generic;

namespace my_orders.Data.Services
{
    public class OrdersService 
    {
        public OrderDbContext _database;


        public OrdersService(OrderDbContext database)                
        {
            _database = database;                                      
        }

        public void AddOrder(OrderModel order)                            
        {
            var _order = new OrderModel()                                    
            {

                TrackerCode = order.TrackerCode,
                TotalPrice = order.TotalPrice,
                PaymentType = order.PaymentType,
                IsActive = order.IsActive,
                CreatedTime = order.CreatedTime,
                CreatedUserId = order.CreatedUserId,
                ModifiedTime = order.ModifiedTime,
                ModifiedUserId = order.ModifiedUserId,
                DeletedTime = order.DeletedTime,
                DeletedUserId = order.DeletedUserId,


                Customer = new CustomerModel
                {
                    CustomerFirstName = order.Customer.CustomerFirstName,
                    CustomerLastName = order.Customer.CustomerLastName,
                    PhoneNumber = order.Customer.PhoneNumber,
                    EmailAllowed = order.Customer.EmailAllowed,
                    EmailAddress = order.Customer.EmailAddress
                },
                Item = new ItemModel { ItemName = order.Item.ItemName, Price = order.Item.Price, Barcode = order.Item.Barcode },
                BillingAddress = new BillingAddressModel {  BillingAddressType= order.BillingAddress.BillingAddressType},
                PayOnDelivery = new PayOnDeliveryModel { PaymentAmount = order.PayOnDelivery.PaymentAmount },
            };
            _database.Order.Add(order);
            _database.SaveChanges();                                         
        }
    }
}
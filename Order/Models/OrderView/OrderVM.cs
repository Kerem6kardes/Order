using BillingAddress.Models;
using Order.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_orders.Data.ViewModels
{
    public class OrderVM
    {
     
        public CustomerModel Customer { get; set; }
        public ItemModel Item { get; set; }
        public PayOnDeliveryModel PayOnDelivery { get; set; }
        public BillingAddressModel BillingAddress { get; set; }
        public CityModel City { get; set; }
        public string TrackerCode { get; set; }
        public string TotalPrice { get; set; }
        public string PaymentType { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAllowed { get; set; }
        public string EmailAddress { get; set; }
        public string ItemName { get; set; }
        public string Price { get; set; }
        public string Barcode { get; set; }
        public string BillingAddressType { get; set; }
        public string PaymentAmount { get; set; }
        public string CityName { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public int CreatedUserId { get; set; } = 1;
        public DateTime ModifiedTime { get; set; } = DateTime.Now;
        public int ModifiedUserId { get; set; } = 1;
        public DateTime DeletedTime { get; set; } = DateTime.Now;
        public int DeletedUserId { get; set; } = 1;


    }

}
using BillingAddress.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Order.Models
{
    public class OrderModel 
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int OrderId { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public int ItemId { get; set; }
        public int PayOnDeliveryId { get; set; }
        public int BillingAddressId { get; set; }
        public string TrackerCode { get; set; }
        public string TotalPrice { get; set; }
        public string PaymentType { get; set; }
        public CustomerModel Customer { get; set; }
        public ItemModel Item { get; set; }
        public PayOnDeliveryModel PayOnDelivery { get; set; }
        public BillingAddressModel BillingAddress { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public int CreatedUserId { get; set; } = 1;
        public DateTime ModifiedTime { get; set; } = DateTime.Now;
        public int ModifiedUserId { get; set; } = 1;
        public DateTime DeletedTime { get; set; } = DateTime.Now;
        public int DeletedUserId { get; set; } = 1;
    }
}

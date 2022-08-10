using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Order.Models
{
    public class PayOnDeliveryModel
    {
        [Key]
        public int PayOnDeliveryId { get; set; }
        [Required]
        public string PaymentAmount { get; set; }
        public List<OrderModel> Order { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public int CreatedUserId { get; set; } = 1;
        public DateTime ModifiedTime { get; set; } = DateTime.Now;
        public int ModifiedUserId { get; set; } = 1;
        public DateTime DeletedTime { get; set; } = DateTime.Now;
        public int DeletedUserId { get; set; } = 1;

    }
}

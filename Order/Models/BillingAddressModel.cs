using Order.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Order.Models
{
    public class BillingAddressModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int BillingAddressId { get; set; }
        [Required]
        public string BillingAddressType { get; set; }
        public List<OrderModel> Order { get; set; } 
        public CityModel City { get; set; } 
        public int OrderId { get; set; }
        public int CityId { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public int CreatedUserId { get; set; } = 1;
        public DateTime ModifiedTime { get; set; } = DateTime.Now;
        public int ModifiedUserId { get; set; } = 1;
        public DateTime DeletedTime { get; set; } = DateTime.Now;
        public int DeletedUserId { get; set; } = 1;
    }
}

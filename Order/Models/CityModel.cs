using BillingAddress.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Order.Models
{
    public class CityModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int CityId { get; set; }
        [Required]
        public string CityName { get; set; }
        public List<BillingAddressModel> BillingAddress { get; set; } 
        public bool IsActive { get; set; } = true;
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public int CreatedUserId { get; set; } = 1;
        public DateTime ModifiedTime { get; set; } = DateTime.Now;
        public int ModifiedUserId { get; set; } = 1;
        public DateTime DeletedTime { get; set; } = DateTime.Now;
        public int DeletedUserId { get; set; } = 1;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Order.Models
{
    public class CustomerModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string PhoneNumber { get; set; }
        public bool EmailAllowed { get; set; }
        public string EmailAddress { get; set; }
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

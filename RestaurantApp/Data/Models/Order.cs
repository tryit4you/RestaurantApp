using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Data.Models
{
    public class Order
    {
        [Key]
        public string OrderId { get; set; }
        public string OrderNo { get; set; }
        public string CustomerId { get; set; }
        public string PayMethod { get; set; }
        public decimal  Total { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

    }
}

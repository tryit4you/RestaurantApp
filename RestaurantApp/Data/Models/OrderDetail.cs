using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Data.Models
{
    public class OrderDetail
    {
        [Key]
        public string OrderItemId { get; set; }
        public string OrderId { get; set; }
        public string ItemId { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }
        [ForeignKey("ItemId")]
        public virtual Item Item { get; set; }

    }
}

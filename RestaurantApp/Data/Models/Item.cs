using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Data.Models
{
    public class Item
    {
        [Key]
        public string Id { get; set; }
        public string  Name { get; set; }
        public decimal Price { get; set; }
    }
}

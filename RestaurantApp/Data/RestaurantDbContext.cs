using Microsoft.EntityFrameworkCore;
using RestaurantApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Data
{
    public class RestaurantDbContext:DbContext
    {
        public RestaurantDbContext(DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<Item> Items{ get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails{ get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
    }
}

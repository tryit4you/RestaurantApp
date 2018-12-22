using RestaurantApp.Data.Interfaces;
using RestaurantApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Data.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly RestaurantDbContext _dbContext;
        public CustomerRepository(RestaurantDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool AddCustomer(Customer customer)
        {
            try
            {
                _dbContext.Customers.Add(customer);
                SaveChange();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<Customer> Customers()
        => _dbContext.Customers.ToList();

        public bool DeleteCustomer(string id)
        {
            try
            {
                var customer = GetCustomer(id);
                _dbContext.Customers.Remove(customer);
                SaveChange();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Customer GetCustomer(string id)
       => _dbContext.Customers.FirstOrDefault(x => x.Id == id);

        public void SaveChange()
        {
            _dbContext.SaveChanges();
        }

        public bool UpdateCustomer(Customer customer)
        {
            var target = GetCustomer(customer.Id);
            try
            {
                target.Name = customer.Name;
                SaveChange();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

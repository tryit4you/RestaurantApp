using RestaurantApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Data.Interfaces
{
    public interface ICustomerRepository
    {
        Customer GetCustomer(string id);
        IEnumerable<Customer> Customers();
         bool UpdateCustomer(Customer customer);
       bool AddCustomer(Customer customer);
       bool DeleteCustomer(string id);
        void SaveChange();
    }
}

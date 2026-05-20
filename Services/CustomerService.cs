using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreManagementSystem.DataStore;
using StoreManagementSystem.Models;

namespace StoreManagementSystem.Services
{
    class CustomerService
    {
        public static void AddCustomer(Customer customer) 
        {
            Store.customers.Add(customer);
        }
        public static void RemoveCustomer(Customer customer)
        {
            Store.customers.Remove(customer); 
        }
        public static Customer GetCustomer(int id) 
        {
            return Store.customers.Find(c => c.Id == id);
        }
        public static void UpdateCustomer(int id, string name, string phoneNumber, string address) 
        {
            Customer c = GetCustomer(id);
            c.Name = name;
            c.PhoneNumber = phoneNumber;
            c.Address = address;
        }
    }
}

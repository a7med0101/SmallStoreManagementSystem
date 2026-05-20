using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreManagementSystem.DataStore;
using StoreManagementSystem.Models;

namespace StoreManagementSystem.Services
{
    class OrderService
    {
        public static void AddOrder(Order order) 
        {
            Store.orders.Add(order);
        }
        public static void RemoveOrder(Order order) 
        {
            Store.orders.Remove(order); 
        }
        public static Order GetOrder(int id) 
        {
            return Store.orders.Find(o => o.OrderID == id);
        }
        public static void UpdateOrder(int OrderID, DateOnly date, int productId, int quantity, int CustomerID) 
        {
            Order o = GetOrder(OrderID);
            o.DateOnly = date;
            o.ProductId = productId;
            o.Quantity = quantity;
            o.CustomerID = CustomerID;
        }
    }
}

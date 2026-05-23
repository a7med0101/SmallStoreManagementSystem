using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreManagementSystem.Models;
using StoreManagementSystem.DataStore;

namespace StoreManagementSystem.Services
{
    class ProductServices
    {
        public static void AddProduct(Product product) 
        {
            Store.products.Add(product);
        }
        public static void RemoveProduct(Product product) 
        {
            Store.products.Remove(product);
        }
        public static Product GetProduct(int id) 
        {
            return Store.products.Find(p => p.Id == id);
        }
        public static void UpdateProduct(int id, string name, double price, double stock) 
        {
            Product p = GetProduct(id);
            p.Name = name;
            p.Price = price;
            p.Stock = stock;
        }

        public static void DisplayProducts()
        {

            foreach (Product product in Store.products)
            {
                Console.WriteLine($"ID: {product.Id}| Name: {product.Name}| Price: {product.Price}");
            }
        }
    }
}

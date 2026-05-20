using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreManagementSystem.Models;

namespace StoreManagementSystem.DataStore
{
    class Store
    {

        public static List<Product> products = new List<Product>()
        {
            new Product { Id = 101, Name = "Tomato", Price = 5.75, Stock = 150 },
            new Product { Id = 102, Name = "Potato", Price = 3.20, Stock = 200 },
            new Product { Id = 103, Name = "Onion", Price = 4.10, Stock = 180 },
            new Product { Id = 104, Name = "Carrot", Price = 6.00, Stock = 120 },
            new Product { Id = 105, Name = "Cucumber", Price = 2.50, Stock = 160 },
            new Product { Id = 106, Name = "Lettuce", Price = 3.75, Stock = 90 },
            new Product { Id = 107, Name = "Spinach", Price = 4.80, Stock = 110 },
            new Product { Id = 108, Name = "Bell Pepper", Price = 7.25, Stock = 140 },
            new Product { Id = 109, Name = "Garlic", Price = 8.00, Stock = 300 },
            new Product { Id = 110, Name = "Zucchini", Price = 5.50, Stock = 100 },
            new Product { Id = 111, Name = "Eggplant", Price = 6.75, Stock = 95 },
            new Product { Id = 112, Name = "Broccoli", Price = 7.00, Stock = 130 },
        };

        public static List<Customer> customers = new List<Customer>()
        {
            new Customer { Id = 100101, Name = "Ahmed Fadel", PhoneNumber = "966580236135", Address = "Mecca" },
            new Customer { Id = 100102, Name = "Omar Nasser", PhoneNumber = "966501234567", Address = "Jeddah" },
            new Customer { Id = 100103, Name = "Mohammed Ali", PhoneNumber = "966512345678", Address = "Riyadh" },
            new Customer { Id = 100104, Name = "Khalid Saleh", PhoneNumber = "966523456789", Address = "Dammam" },
            new Customer { Id = 100105, Name = "Faisal Hassan", PhoneNumber = "966534567890", Address = "Medina" },
            new Customer { Id = 100106, Name = "Yousef Ibrahim", PhoneNumber = "966545678901", Address = "Taif" },
            new Customer { Id = 100107, Name = "Saad Majed", PhoneNumber = "966556789012", Address = "Abha" },
            new Customer { Id = 100108, Name = "Nasser Fahad", PhoneNumber = "966567890123", Address = "Tabuk" },
            new Customer { Id = 100109, Name = "Abdulrahman Omar", PhoneNumber = "966578901234", Address = "Hail" },
            new Customer { Id = 100110, Name = "Turki Sultan", PhoneNumber = "966589012345", Address = "Jazan" },
        };

        public static List<Order> orders = new List<Order>()
        {
            new Order { OrderID = 50001, DateOnly = new DateOnly(2026, 5, 1), CustomerID = 100101, ProductId = 101, Quantity = 3 },
            new Order { OrderID = 50002, DateOnly = new DateOnly(2026, 5, 2), CustomerID = 100102, ProductId = 104, Quantity = 5 },
            new Order { OrderID = 50003, DateOnly = new DateOnly(2026, 5, 3), CustomerID = 100103, ProductId = 102, Quantity = 2 },
            new Order { OrderID = 50004, DateOnly = new DateOnly(2026, 5, 4), CustomerID = 100104, ProductId = 108, Quantity = 1 },
            new Order { OrderID = 50005, DateOnly = new DateOnly(2026, 5, 5), CustomerID = 100105, ProductId = 103, Quantity = 4 },
            new Order { OrderID = 50006, DateOnly = new DateOnly(2026, 5, 6), CustomerID = 100106, ProductId = 107, Quantity = 6 },
            new Order { OrderID = 50007, DateOnly = new DateOnly(2026, 5, 7), CustomerID = 100107, ProductId = 105, Quantity = 2 },
            new Order { OrderID = 50008, DateOnly = new DateOnly(2026, 5, 8), CustomerID = 100108, ProductId = 106, Quantity = 1 },
            new Order { OrderID = 50009, DateOnly = new DateOnly(2026, 5, 9), CustomerID = 100109, ProductId = 109, Quantity = 10 },
            new Order { OrderID = 50010, DateOnly = new DateOnly(2026, 5, 10), CustomerID = 100110, ProductId = 110, Quantity = 3 },
        };



    }

}

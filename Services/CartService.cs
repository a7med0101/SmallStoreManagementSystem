using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreManagementSystem.DataStore;
using StoreManagementSystem.Models;

namespace StoreManagementSystem.Services
{
    class CartService
    {
        public static List<CartItem> cart = new List<CartItem>();


        public static void AddToCart(CartItem item) 
        {
            cart.Add(item);
        }

        public static void RemoveFromCart(CartItem item) 
        {
            cart.Remove(item);
        }

        public static List<CartItem> GetCart() 
        {
            return cart;
        }
        public static double GetTotal() 
        {
            double total = 0;
            foreach (CartItem item in cart) 
            {
                total += item.Product.Price * item.Quantity;
            }
            return total;
        }

        
    }
}

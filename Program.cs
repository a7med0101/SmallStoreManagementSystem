using StoreManagementSystem.DataStore;
using StoreManagementSystem.Models;
using StoreManagementSystem.Services;

namespace StoreManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string choice = "";
            DisplayMenu();  
            Console.Write("Please select an option: ");
            choice = Console.ReadLine();
            while (choice != null && choice != "0") 
            {
                switch (choice)
                {
                    case "1":
                        {
                            ProductServices.DisplayProducts();
                            Console.Write("Please Enter ID Of Product: ");
                            if (int.TryParse(Console.ReadLine(), out int productId))
                            {
                                Console.Write("Please Enter the Quantity: ");
                                if (int.TryParse(Console.ReadLine(), out int quantity))
                                {
                                    var product = ProductServices.GetProduct(productId);
                                    CartItem productItem = new CartItem()
                                    {
                                        Product = product,
                                        Quantity = quantity
                                    };
                                    CartService.AddToCart(productItem);
                                }
                                else
                                    Console.WriteLine("Error!!! Plaese Enter Only numbers ");
                            }
                            else
                                Console.WriteLine("Error!!! Plaese Enter Only numbers 1XX");
                            break;
                        }


                    case "2":
                        {
                            Console.Write("Please Enter ID Of Product: ");
                            if (int.TryParse(Console.ReadLine(), out int removeId))
                            {
                                var product = ProductServices.GetProduct(removeId);
                                CartItem itemRemove = CartService.cart.Find(i => i.Product.Id == removeId);
                                CartService.RemoveFromCart(itemRemove);
                            }
                            else
                                Console.WriteLine("Error Plaese Enter Id of Product");
                            break;
                        }
                    case "3":
                        {
                            DisplayCart();
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("Plaece Enter Name Of Product: ");
                            string nameOfProduct = Console.ReadLine();
                            if (!int.TryParse(nameOfProduct, out int name ))
                            {
                                if (FoundProduct(nameOfProduct))
                                {
                                    DisplayProductByName(nameOfProduct);
                                }
                                else
                                    Console.WriteLine("Sorry The Product Not Found!!!");

                            }
                            break;
                        }
                }
                Console.Write("Please Enter Number: ");
                choice = Console.ReadLine();
            }
            
        }
        public static bool FoundProduct(string nameOfproduct)
        {
            return Store.products.Any(p => p.Name.ToLower() == nameOfproduct);
        }
        public static void DisplayProductByName(string product)
        {
            var product1 = Store.products.Find(p => p.Name.ToLower() == product);
            Console.WriteLine($"ID: {product1.Id} | Price: {product1.Price}");
            
        }

        public static void DisplayCart() 
        {
            var cartItem = CartService.cart;
            foreach (CartItem cart in cartItem) 
                Console.WriteLine($"{cart.Product.Name} | Quantity: {cart.Quantity}");
            
            var result = CartService.GetTotal();
            Console.WriteLine($"{result}$");
        }
        public static void DisplayMenu()
        {
            Console.WriteLine("===== Fruit Store =====");
            Console.WriteLine("1/Add to Cart");
            Console.WriteLine("2/Remove from Cart");
            Console.WriteLine("3/View Cart");
            Console.WriteLine("4/Search Product");
            Console.WriteLine("0/Exit");
        }

        
    }
}


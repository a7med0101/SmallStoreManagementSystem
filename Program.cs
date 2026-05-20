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
            PrintProUI();
            Console.Write("Please Enter Number: ");
            choice = Console.ReadLine();
            while (choice != null && choice != "0") 
            {
                //PrintUI();
                //choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ProductServices.PrintProduct();
                        Console.Write("Please Enter ID Of Product: ");
                        int IdP = int.Parse(Console.ReadLine()); 
                        Console.Write("Please Enter The Quantity: ");
                        int QuP = int.Parse(Console.ReadLine());
                        var  product = ProductServices.GetProduct(IdP);
                        CartItem productItem = new CartItem()
                        {
                            Product = product,
                            Quantity = QuP
                        };
                        CartService.AddToCart(productItem);
                        break;
                    case "2":
                        Console.Write("Please Enter ID Of Product: ");
                        int removeId = int.Parse(Console.ReadLine());
                        product = ProductServices.GetProduct(removeId);
                        CartItem itemRemove = CartService.cart.Find(i => i.Product.Id == removeId);
                        CartService.RemoveFromCart(itemRemove);
                        break;
                    case "3":
                        PrintCartUI();
                        break;
                    case "4":
                        Console.WriteLine("Plaece Enter Name Of Product: ");
                        PrintProdWithNameUI(Console.ReadLine());
                        break;
                }
                Console.Write("Please Enter Number: ");
                choice = Console.ReadLine();
            }
            
        }

        public static void PrintProdWithNameUI(string product)
        {
            var product1 = Store.products.Find(p => p.Name == product);
            Console.WriteLine($"ID: {product1.Id} | Price: {product1.Price}");
            
        }

        public static void PrintCartUI() 
        {
            var cartItem = CartService.cart;
            foreach (CartItem cart in cartItem) 
                Console.WriteLine($"{cart.Product.Name} | Quantity: {cart.Quantity}");
            
            var result = CartService.GetTotal();
            Console.WriteLine($"{result}$");
        }
        public static void PrintProUI()
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


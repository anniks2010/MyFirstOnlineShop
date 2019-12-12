using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirtOnlineShop
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Create a Warehouse objekt
            Warehouse currentlyInStock = new Warehouse();
            ///create a Shopping Cart object
            ShopingCart shoppingCart = new ShopingCart();
            //display the warehouse content
            currentlyInStock.PrintInStock();

            AddItemsToShoppingCart(currentlyInStock, shoppingCart);


            while (true)
            {
                Console.WriteLine("Add/Remove/Confirm");
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "add")
                {
                    AddItemsToShoppingCart(currentlyInStock, shoppingCart);
                }
                else if (userInput == "remove")
                {
                    Console.WriteLine($"Enter the id of the product to add it to the shopping cart: ");
                    int userIdToRemove = int.Parse(Console.ReadLine());
                    shoppingCart.RemoveFromShoppingCard(userIdToRemove);
                }
                

                
            }




            Console.ReadLine();

        }
        public static void AddItemsToShoppingCart(Warehouse currentlyInStock,ShopingCart shoppingCart)
        {
            Console.WriteLine($"Enter the id of the product to add it to the shopping cart: ");
            int productId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the numbers of items to add to the shopping cart: ");
            int quantity = int.Parse(Console.ReadLine());

            Article articleToAdd = currentlyInStock.GetFromStock(productId);
            shoppingCart.AddToShoppingCart(articleToAdd, quantity);
            shoppingCart.PrintShoppingCart();
        }
    }
}

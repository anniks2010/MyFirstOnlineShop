using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirtOnlineShop
{
    class ShopingCart
    {
        List<Item> shoppingCart;
        double total;

        public ShopingCart()
        {
            shoppingCart = new List<Item>();
            total = 0;
        }
        public double Total
        {
            get { return total; }
        }


        public void RemoveFromShoppingCard(int id)
        {
            for (int i = 0; i < shoppingCart.Count; i++)
            {
                if (shoppingCart[i].Article.Id == id)
                {
                    Console.WriteLine($"{shoppingCart[i].Article.Name} has been removed");
                    shoppingCart.Remove(shoppingCart[i]);
                }
            }
            PrintShoppingCart();
        }
        public void AddToShoppingCart(Article article, int quantity)
        {
            Item newItem = new Item(article, quantity); ////uue objekti loomine uues klassis
            shoppingCart.Add(newItem);
        }
        public void PrintShoppingCart()
        {
            if (shoppingCart.Count== 0)
            {
                Console.WriteLine($"shopping cart is empty");
            }
            else
            {
                foreach(Item item in shoppingCart)
                {
                    item.PrintItem();
                ////Console.WriteLine($"{item.CalculateItemTotal()}");
                }
            }
        }

        ///calculate shopping chart total
        public void PrintTotal()
        {
            foreach (Item item in shoppingCart)
            {
                total += item.CalculateItemTotal();
            }
        }
    }
}

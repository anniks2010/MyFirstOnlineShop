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

        public ShopingCart()
        {
            shoppingCart = new List<Item>();
        }

        public void AddToShoppingCart(Article article, int quantity)
        {
            Item newItem = new Item(article, quantity); ////uue objekti loomine uues klassis
            shoppingCart.Add(newItem);
        }
        public void PrintShoppingCart()
        {
            foreach(Item item in shoppingCart)
            {
                Console.WriteLine($"{item.Article}");
            }
        }
    }
}

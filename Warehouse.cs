using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirtOnlineShop
{
    class Warehouse
    {
        List<Article> InStock;
        
        /// constructor:
        public Warehouse()
        {
            InStock = new List<Article>(); ///loon lao siin konstruktoris, et säästa resursse.
            Article cinnamonBun = new Article("cinnamon bun", Category.PASTRY, 0.39);
            InStock.Add(cinnamonBun);
            Article ciabatta = new Article("ciabatta", Category.PASTRY, 0.99);
            InStock.Add(ciabatta);
            Article milk = new Article("milk", Category.DAIRY, 0.59);
            InStock.Add(milk);
            Article yogurt = new Article("yogurt", Category.DAIRY, 0.89);
            InStock.Add(yogurt);
            Article kalevChoclate = new Article("Kalev choclate", Category.CONFECTIONERY, 1.99);
            InStock.Add(kalevChoclate);
            Article gummyBears = new Article("Gummy Bears", Category.CONFECTIONERY, 1.99);
            InStock.Add(gummyBears);
            Article cocaCola = new Article("Coca Cola", Category.BEVERAGES, 0.99);
            InStock.Add(cocaCola);
            Article crafterBeer = new Article("Crafted Beer", Category.BEVERAGES, 6);
            InStock.Add(crafterBeer);
            Article orange = new Article("orange", Category.FRUIT, 0.4);
            InStock.Add(orange);
            Article apple = new Article("apple", Category.FRUIT, 0.2);
            InStock.Add(apple);
            Article potato = new Article("potato", Category.VEGGIE, 0.29);
            InStock.Add(potato);
            Article tomato = new Article("tomato", Category.VEGGIE, 1.29);
            InStock.Add(tomato);
            Article cannedBeans = new Article("Kidney beans in tomato sauce", Category.CANNED_FOOD, 0.69);
            InStock.Add(cannedBeans);
            Article turistiEine = new Article("Turisti eine", Category.CANNED_FOOD, 2);
            InStock.Add(turistiEine);
            Article salmon = new Article("salmon", Category.FISH, 4.99);
            InStock.Add(salmon);
            Article fishFingers = new Article("Fish Fingers", Category.FISH, 1.69);
            InStock.Add(fishFingers);
            Article pork = new Article("pork", Category.MEAT, 4.99);
            InStock.Add(pork);
            Article beef = new Article("beef", Category.MEAT, 10);
            InStock.Add(beef);
            Article shampoo = new Article("shampoo", Category.TOILETRIES, 4);
            InStock.Add(shampoo);
            Article conditioner = new Article("conditioner", Category.TOILETRIES, 4);
            InStock.Add(conditioner);

           
               
        }
        public void PrintInStock()
        {
            foreach(Article article in InStock)
            {
                Console.WriteLine($"Product: {article.Name}");
                Console.WriteLine($"Category: {article.Category}");
                Console.WriteLine($"Price: {article.Price}");
                Console.WriteLine();
            }
        }
        
     //TODO add items to chart option
        /*private bool IsInStock(string userInput)
        {
            foreach(Article article in InStock)
            {
                if (article.Name.Contains(userInput))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }*/
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirtOnlineShop
{
    class Item
    {
        Article article;
        int quantity;

        public Item(Article _article, int _quantity)
        {
            article = _article;
            quantity = _quantity;
        }
        public string Article
        {
            get { return $"{article.Name} \n Category: {article.Category} \n Price: {article.Price} \n Quantity: {quantity}"; }
        }
        
        
        
        public double CalculateItemTotal()
        {
            return article.Price * quantity;
        }
        
    }
}

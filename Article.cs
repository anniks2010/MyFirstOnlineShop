using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirtOnlineShop
{
    enum Category
    {
        PASTRY,
        DAIRY,
        CONFECTIONERY,
        CANNED_FOOD,
        MEAT,
        FISH,
        FRUIT,
        VEGGIE,
        TOILETRIES,
        BEVERAGES

    }
    class Article
    {
        string name;
        Category category;
        double price;

        public Article(string _name, Category _category, double _price)
        {
            name = _name;
            category = _category;
            price = _price;
        }
        public string Name
        {
            get { return name; }
        }
        public string Category
        {
            get { return category.ToString(); } ////tahame lihtsalt string nimena saada kategooria
        }
        public double Price
        {
            get { return price; }
        }
    }
}

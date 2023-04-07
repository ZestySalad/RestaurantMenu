using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaileysRestaurant
{
   public abstract class Items
    {
        public decimal Price { get; set; }
        public string Itemname { get; set; }
        public string Description { get; set; }
    }

    class Apps : Items
    {
        public Apps(string itemName, string description, decimal price)
        {
            Itemname = itemName;
            Description = description;
            Price = price;
        }
    }

    class Entree : Items
    {
        public Entree(string itemName, string description, decimal price)
        {
            Itemname = itemName;
            Description = description;
            Price = price;
        }
    }

    class Dessert : Items
    {
        public Dessert(string itemName, string description, decimal price)
        {
            Itemname = itemName;
            Description = description;
            Price = price;
        }
    }
}

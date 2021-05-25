using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShopApp.Models.Base
{
    public abstract class Item
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }


        public virtual string ToDescriptionString()
        {
            return $"Name: {Name} Price: {Price} Quantity: { Quantity }";
        }
    }
}

using ConsoleShopApp.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShopApp.Models
{
    class Book : Item
    {
        public string Author { get; set; }
        public string Publisher { get; set; }

        public new string ToDescriptionString()
        {
            return $"Author: {Author} Title: {Name} Publisher: {Publisher}  Price: {Price} Quantity: { Quantity }";
        }
    }
}

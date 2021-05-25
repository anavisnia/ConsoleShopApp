using ConsoleShopApp.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShopApp.Models
{
    class Cup : Item
    {
        public string Color { get; set; }
        public string Logo { get; set; }

        public override string ToDescriptionString()
        {
            return $"Name: {Name} Price: {Price} Color: {Color} Logo: {Logo} Quantity: { Quantity }";
        }
    }
}

using System;

namespace ConsoleShopApp
{
    internal class Shop
    {
        private readonly string _name;
        public Shop(string name)
        {
            //this.name = name;
            _name = name;
        }

        public Shop() : this("Default")
        {

        }

        public string GetInformation()
        {
            return $"Shop: {_name}";
        }

        public void ListItems()
        {
        }

        public void Buy(string v1, int v2)
        {
        }

        public void LoadItems(string itemName, int quantity)
        {
            // To load items
        }
    }
}
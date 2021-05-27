using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleShopApp.Models;
using ConsoleShopApp.Models.Base;
using ConsoleShopApp.Helpers;

namespace ConsoleShopApp
{
    public class Shop
    {
        private readonly string _name;

        public List<Item> Items { get; set; }

        public Shop(string name)
        {
            //this.name = name;
            _name = name;
            Items = new List<Item>();
        }

        public Shop() : this("Default")
        {

        }

        public string GetInformation()
        {
            return $"Shop: {_name}";
        }

        public void AddItem(string name, decimal price, int quantity)
        {
            bool isUpperCase = HelperStrings.UpperOrLower(name);
            if (!isUpperCase)
            {
                name = HelperStrings.ToUpperCase(name);
            }

            bool doExist = Items.Any(p => p.Name == name);
            if (doExist)
            {
                Console.WriteLine($"Item with this name already exist: {name}.");
                return;
            }

            Item toAddItem = new Item() { Name = name, Price = price, Quantity = quantity };
            this.Items.Add(toAddItem);
            Console.WriteLine($"Item added: {name}");
        }

        public void ListItems()
        {
            Console.WriteLine("List of items:");
            foreach (var item in Items)
            {
                Console.WriteLine(item.ToDescriptionString());
            }
        }

        public void Buy(string name, int quantity)
        {

        }

    }
}
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
            _name = name; //this.name = name;
            Items = new List<Item>();
        }

        public Shop() : this("Default")
        {

        }

        public string GetInformation()
        {
            return $"Shop: {_name}";
        }

        public void AddItem(string name, int quantity)
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

            Item toAddItem = new Item() { Name = name, Quantity = quantity };
            this.Items.Add(toAddItem);
            Console.WriteLine($"Item added: {name}");
        }

        public void ListItems()
        {
            Console.WriteLine("List of items:");
            foreach (var item in Items)
            {
                if(item.Quantity != 0)
                {
                    Console.WriteLine(item.ToDescriptionString());
                }
            }
        }

        public void Buy(string name, int quantity)
        {
            bool isUpperCase = HelperStrings.UpperOrLower(name);
            if (!isUpperCase)
            {
                name = HelperStrings.ToUpperCase(name);
            }

            bool doExist = Items.Any(p => p.Name == name);
            if (doExist)
            {
                foreach (var item in Items)
                {
                    if(item.Name == name && item.Quantity != 0)
                    {
                        if(quantity > item.Quantity)
                        {
                            Console.WriteLine($"You can't buy more than {item.Quantity}");
                            return;
                        }
                        item.Quantity -= quantity;
                        Console.WriteLine($"You succsessfully bought {quantity} {name}");
                    }
                    else if(item.Name == name && item.Quantity == 0)
                    {
                        Console.WriteLine("There are no products left");
                    };
                }
            }
            else
            {
                Console.WriteLine("Such product do not exist...");
            }
        }

    }
}
using ConsoleShopApp.Models;
using ConsoleShopApp.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleShopApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var shop = new Shop();
            bool exit = false;

            shop.AddItem("Cup", 20);
            shop.AddItem("Candy", 40);
            shop.AddItem("Book", 70);
            Console.Clear();


            Console.WriteLine("===== Console Shop =====");
            do
            {
                Console.WriteLine("List of commands:");
                Console.WriteLine("Write 'Add' to add products to the store:'Add Cup 80' and press enter");
                Console.WriteLine("Write 'Buy' to buy products: 'Buy Cup 80' and press enter");
                Console.WriteLine("Write 'List' to see all available products, their price and quantity: 'List' and press enter");
                Console.WriteLine("Write 'Exit' and press enter to stop the program");
                string userInput = Console.ReadLine().Trim();

                List<string> userInputList = userInput.Trim().Split(' ').ToList();
                userInputList = userInputList.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();


                int itemQuantity;
                switch (userInputList[0])
                {
                    case "List":
                        shop.ListItems();
                        break;
                    case "Add":
                        Int32.TryParse(userInputList[2], out itemQuantity);
                        shop.AddItem(userInputList[1], itemQuantity);
                        break;
                    case "Buy":
                        Int32.TryParse(userInputList[2], out itemQuantity);
                        shop.Buy(userInputList[1], itemQuantity);
                        break;
                    case "Exit":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Nothing related was writen...");
                        break;
                }


            } while (!exit);


        }
    }
}

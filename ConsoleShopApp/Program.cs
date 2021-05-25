using ConsoleShopApp.Models;
using ConsoleShopApp.Models.Base;
using System;
using System.Collections.Generic;

namespace ConsoleShopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Sukurti parduotuvę, kuri parduoda saldainius, knygas, puodukus. 
            Jie visi turi pavadinimą, kiekį. Programa turėtų nepasibaigti įrašius tik vieną komandą,
            turėtų leisti kelias. Reikia panaudoti objektinį programavimą, tureti minimum 2 klases.

            Galimos komandos konsolėje:
            "List" išspausdina informacija, ką galima nusipirkti parduotuvėje ir kokios kainos. išpirktų produktų neturėtų rodyti.
            "Buy Candy 20" - turėtų nupirkti visus egzistuojančius toks item egzistuoja parduotuvėje ir yra toks kiekis. Jei ne, turėtų parodyti atitinkamą žinutę.
            "Add Cup 30" - turėtų papildyti parduotuvę su atitinkamu produktu ir kiekiu. Tai turętų atsivaizduoti ir "List" komandoje. 
            Jei tokiu produktų jau yra, papildyti.


            Extra: 
            Sukurti Vartotojo klasę, kuri laikytų pinigų balancą.
            Pakeisti kodą, kad atsirastų kainos. Modifikuoti List, kad parodytų ir kainas.
            Papildomos komandos:
            "Show Balance" parodyti kiek pinigų liko. Modifikuoti Buy komandą, kuri neleistų nusipirkti, jei neužtenka pinigų. 
            "Topup 30": papildytų sąskaitą.
             */

            var shop = new Shop();

            List<Book> books = new List<Book>();

            books.Add(new Book()
            {
                Name = "To Kill a Mockingbird",
                Price = 15M,
                Author = "Harper Lee",
                Quantity = 23,
                Publisher = "J. B. Lippincott & Co."
            });

            books.Add(new Book()
            {
                Name = "1984",
                Price = 5M,
                Author = "George Orwell",
                Quantity = 30,
                Publisher = "Harvill Secker"
            });

            books.Add(new Book()
            {
                Name = "The Great Gatsby",
                Price = 25M,
                Author = "F. Scott Fitzgerald",
                Quantity = 5,
                Publisher = "Charles Scribner's Sons"
            });

            List<Candy> candies = new List<Candy>();
            candies.Add(new Candy()
            {
                Name = "Sour",
                Price = 2M,
                Quantity = 40
            });

            candies.Add(new Candy()
            {
                Name = "Sweet",
                Price = 1.5M,
                Quantity = 10
            });

            candies.Add(new Candy()
            {
                Name = "Jelly",
                Price = 3.2M,
                Quantity = 34
            });

            List<Cup> cups = new List<Cup>();

            cups.Add(new Cup()
            {
                Name = "GlassWall",
                Price = 4M,
                Quantity = 12,
                Color = "transparent",
                Logo = "go go go"
            });

            cups.Add(new Cup()
            {
                Name = "Sen",
                Price = 2M,
                Quantity = 2,
                Color = "blue",
                Logo = "With coffe I can rule the world!"
            });


        }
    }
}

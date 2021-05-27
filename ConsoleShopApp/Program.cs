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

            shop.AddItem("Cup", 2, 20);
            shop.AddItem("Cup", 2, 20); // exists
            shop.AddItem("candy", 1, 40); // will be uppercased and added
            shop.AddItem("Candy", 3, 20); // exists

            //shop.AddItem("Book", 7, 70);
            //shop.AddItem("Candy", 1, 40);
            //shop.AddItem("Candy", 5, 20);


            shop.ListItems();

        }
    }
}

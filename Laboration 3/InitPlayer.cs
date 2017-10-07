using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_3
{//InitPlayer är en hjälpklass som skapar playerobjekt med tillgivna attribut.
    class InitPlayer
    {//lokala variabler.
        private static int playerAge;
        private static string ageParse;
        private static string country;
        private static string name;
        
        //en metod som returnerar ett Player objekt.
        protected static Player NewPlayer()
        {
            //En Player objekt referens skapas som heter BadAge. Detta objekt används som retur värde om olovlig ålder anges.
            Player BadAge;
        Console.WriteLine("Welcome to Super-Syntax-Casino!");
            Console.Write("Please enter age: ");
            //en do-while funktion som kollar att stringen ageParse går att göra en parse ur.
            do
                ageParse = Console.ReadLine();
            while (int.TryParse(ageParse, out int i) == false);
            //När do-while funktionen avklarats parseas ageParse och värdet tillges till int variabeln playerAge
            playerAge = int.Parse(ageParse);
            //Nedanför följer två if funktioner som skapar ett nytt Player objekt som har ett olovligt age värde. Objektet returneras därefter.
            if (playerAge < 18) //för låg ålder.
            {
                BadAge = new Player(playerAge);
                return BadAge;
            }
            if (playerAge > 70) // för hög ålder.
            {
                BadAge = new Player(playerAge);
                return BadAge;
            }
            Console.WriteLine("age: " + playerAge);
            Console.Write("What is your name? ");
            //Här skriver spelaren in sitt namn.
            name = Console.ReadLine();
            Console.WriteLine("Thank you " + name + "!");
            Console.Write("What country do you come from " + name + "? ");
            //Spelaren skriver in sin nationallitet.
            country = Console.ReadLine();
            Console.WriteLine("Wow! I always wanted to go to " + country + ". It's such a cool country!");
            //Här skapas ett nytt Player objekt som sedan returneras. Argumenten som används är de värden som tillsatts i metoden i form av name, country och playerAge.
            Player returnPlayer = new Player(name, country, playerAge);
            return returnPlayer;

        }
    }
}

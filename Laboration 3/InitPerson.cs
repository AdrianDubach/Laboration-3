using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_3
{
    class InitPlayer
    {
        private static int playerAge;
        private static string ageParse;
        private static string country;
        private static string name;

        public static Player NewPlayer()
        {
            Player BadAge = new Player(1);
            Console.WriteLine("Welcome to Super-Syntax-Casino-Royale-SpinEveryDay-give-us-all-your-money-Casino!");
            Console.Write("Please enter age: ");
            do
                ageParse = Console.ReadLine();
            while (int.TryParse(ageParse, out int i) == false);
            playerAge = int.Parse(ageParse);
            if (playerAge < 18)
                return BadAge;
            Console.WriteLine("age: " + playerAge);
            Console.Write("What is your name? ");
            name = Console.ReadLine();
            Console.WriteLine("Thank you " + name + "!");
            Console.Write("What country do you come from " + name + "? ");
            country = Console.ReadLine();
            Console.WriteLine("Wow! I always wanted to go to " + country + ". It's such a cool country!");
            Player returnPlayer = new Player(name, country, playerAge);
            return returnPlayer;

        }
    }
}

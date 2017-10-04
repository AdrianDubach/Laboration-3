using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_3
{
    class Program
    {
        private static string moneyLeft;
            static void Main(string[] args)
        {
           Player p = InitPlayer.NewPlayer();
            try
            {
                if (p.Age < 18) throw new AgeException("Too young!");
                if (p.Age > 70) throw new AgeException("Too Old!");
                
                   { moneyLeft = Spinner.Spin(p);
                    Console.WriteLine(moneyLeft); }
            }
            catch (AgeException ageExc)
            { Console.WriteLine(ageExc.Message); }
            Console.Read();
        }
}
}

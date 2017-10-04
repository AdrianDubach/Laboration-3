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
            if (p.Age < 18)
            {
                Console.WriteLine("You're too young!");
            }
            else
            moneyLeft = Spinner.Spin(p);
            Console.WriteLine(moneyLeft);
            Console.Read();
        }
}
}

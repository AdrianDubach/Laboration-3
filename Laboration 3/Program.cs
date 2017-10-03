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


            moneyLeft = Spinner.Spin();
            Console.WriteLine(moneyLeft);
            Console.Read();
        }
}
}

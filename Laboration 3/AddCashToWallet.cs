using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_3
{
    class AddCashToWallet
    {
        public static void AddCashToPlayWith(Player p)
        {
            Console.WriteLine("How much money do you want to deposit to your wallet " + p.Name + "?");
            while (p.PlayerWallet.CashCheck() <= 0)
            {
                double.TryParse(Console.ReadLine(), out double startUpCash);
                p.AddCash(startUpCash);
            }
            Console.Clear();
            Console.WriteLine("Good luck " + p.Name + "! You have " + p.PlayerWallet.CashCheck() + " money in your wallet!");
        }
    }
}

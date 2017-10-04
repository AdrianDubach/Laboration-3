using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_3
{
    class Spinner
    {
        private static double moneySpent;
        private static double moneyLost;
        private static double moneyWon;
        private static string input;
        private static double playerBet;
        private static double winnings;


        public static string Spin(Player p)
        {
            if (p.PlayerWallet.CashCheck() <= 0)
              moneySpent = moneySpent + AddCashToWallet.AddCashToPlayWith(p);


            while (input != "N" || input != "NO")
            {

                Console.WriteLine("Do you want to spin, " + p.Name + "? Yes/No");
                do input = Console.ReadLine().ToUpper();
                while ((input == "Y" || input == "YES" || input == "N" || input == "NO") == false);
                if (input == "Y" || input == "YES")
                {
                    Console.Clear();
                    Console.WriteLine("Balance: " + p.PlayerWallet.CashCheck());
                    Console.Write("Place a bet:");
                    do input = Console.ReadLine();
                    while (!double.TryParse(input, out ref double i));
                    playerBet = double.Parse(input);
                    moneyLost = moneyLost + playerBet;
                    if (playerBet <= p.PlayerWallet.CashCheck())
                    {
                        p.WithdrawCash(playerBet);
                        Console.WriteLine();
                        winnings = GameBoard.Game(playerBet);
                        if (winnings > 0)
                            Console.WriteLine("You won " + winnings + ", congratulations " + p.Name + "!");
                        p.AddCash(winnings);
                        moneyWon = moneyWon + winnings;
                    }
                    else
                    { Console.WriteLine("Not enough cash to bet that high!"); }

                    Console.WriteLine("you have " + p.PlayerWallet.CashCheck() + " money left!");
                }
                if (input == "N" || input == "NO")
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for playing, " + p.Name + "!");
                    if (moneyLost > moneyWon)
                    return ("You spent: " + moneySpent + " You Lost: " + moneyLost + " You won: " + moneyWon + ". Better luck next time, " + p.Name);
                    if (moneyWon > moneyLost)
                        return ("You spent: " + moneySpent + " You Lost: " + moneyLost + " You won: " + moneyWon + ". Good run, " + p.Name + " You should be crowned The king of " +p.Country + " with the amount of cash you just won!");
                }
                if (p.PlayerWallet.CashCheck() <= 0)
                {
                    Console.WriteLine("Oh no " + p.Name + "! You lost all your money. Do you wish to insert more? Yes/No");
                    input = Console.ReadLine().ToUpper();
                    if (input == "Y" || input == "YES")
                        moneySpent = moneySpent + AddCashToWallet.AddCashToPlayWith(p);
                    if (input == "N" || input == "NO")
                        return ("You walk away a broken man, " + p.PlayerWallet.CashCheck() + " money to your name! FeelsBadMan.");
                }
            }
            return ("You spent: " + moneySpent + " You Lost: " + moneyLost + " You won: " + moneyWon);

        }
    }
}


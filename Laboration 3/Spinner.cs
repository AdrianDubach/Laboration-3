using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_3
{
    class Spinner
    {
        private static string input;
        private static double playerBet;
        private static double winnings;
        //private static double cashStatus;


        public static string Spin()
        {

            Player p = InitPlayer.NewPlayer();
            if (p.Age < 18)
            {
                return ("You're too young!");
            }
            else
            {
                Console.WriteLine("How much money do you want to play with " + p.Name + "?");
                while (p.PlayerWallet.CashCheck() <= 0)
                {
                    double.TryParse(Console.ReadLine(), out double playerCurrency);
                    p.AddCash(playerCurrency);
                }

                Console.WriteLine("Good luck " + p.Name + "! You have " + p.PlayerWallet.CashCheck() + " money in your wallet!");
                //cashStatus = p.PlayerWallet.CashCheck();
                while (p.PlayerWallet.CashCheck() >= 10)
                {

                    Console.WriteLine("Do you want to spin, " + p.Name + "? Y/N");
                    do input = Console.ReadLine().ToUpper();
                    while ((input == "Y" || input == "N") == false);
                    if (input == "Y")
                    {
                        Console.Write("Place a bet: 10, 20, 50, 100 ");
                        do input = Console.ReadLine();
                        while ((input == "10" || input == "20" || input == "50" || input == "100") == false);
                        if (input == "10")
                        {
                            playerBet = 10;
                            Console.WriteLine("You bet 10!");
                        }
                        if (input == "20")
                        {
                            playerBet = 20;
                            Console.WriteLine("You bet 20!");
                        }
                        if (input == "50")
                        {
                            playerBet = 50;
                            Console.WriteLine("You bet 50!");
                        }
                        if (input == "100")
                        {
                            playerBet = 100;
                            Console.WriteLine("You bet 100!");
                        }

                        if (playerBet <= p.PlayerWallet.CashCheck())
                        {
                            p.WithdrawCash(playerBet);
                            Console.WriteLine();
                            winnings = GameBoard.Game(playerBet);
                            if (winnings > 0)
                                Console.WriteLine("You won " + winnings + ", congratulations " + p.Name + "!");
                            p.AddCash(winnings);
                        }
                        else
                        { Console.WriteLine("Not enough cash to bet that high!"); }

                        Console.WriteLine("you have " + p.PlayerWallet.CashCheck() + " money left!");
                    }
                    if (input == "N")
                    {
                        Console.WriteLine("Thank you for playing, " + p.Name + "!");
                        return ("You walk away with " + p.PlayerWallet.CashCheck() + " money!");
                    }
                }
                return ("You walk away with " + p.PlayerWallet.CashCheck() + " money! FeelsBadMan");
            }
        }
        }
    }


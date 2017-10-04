﻿using System;
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


        public static string Spin(Player p)
        {
            if (p.PlayerWallet.CashCheck() <= 0)
                AddCashToWallet.AddCashToPlayWith(p);


                while (p.PlayerWallet.CashCheck() > 0)
                {

                    Console.WriteLine("Do you want to spin, " + p.Name + "? Yes/No");
                    do input = Console.ReadLine().ToUpper();
                    while ((input =="Y" || input == "YES" ||input == "N" ||input == "NO") == false);
                    if (input == "Y" || input == "YES")
                    {
                        Console.Clear();
                        Console.WriteLine("Balance: " + p.PlayerWallet.CashCheck());
                        Console.Write("Place a bet:");
                        do input = Console.ReadLine();
                        while (!double.TryParse(input, out ref double i));
                        playerBet = double.Parse(input);
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
                    if (input == "N" || input == "NO")
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for playing, " + p.Name + "!");
                        return ("You walk away with " + p.PlayerWallet.CashCheck() + " money!");
                    }
                    if (p.PlayerWallet.CashCheck() <= 0)

                    Console.WriteLine("Oh no " + p.Name + "! You lost all your money. Do you wish to insert more?");
            }

                return ("You walk away a broken man, " + p.PlayerWallet.CashCheck() + " money to your name! FeelsBadMan.");
            
        }
        }
    }


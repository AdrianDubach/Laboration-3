using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_3
{
    class Spinner : GameBoard
    {// dessa tre värden används enbart för statistiska syften
        private double moneyDeposited;
        private double moneyLost;
        private double moneyWon;
        //dessa tre värde används mer funktionellt i koden.
        private string input;
        private double playerBet;
        private double winnings;


        public string Spin(Player p)
        {/*Denna funktion kollar till en början att Wallet klassen inte har ett positivt _balance värde. 
            Om värdet är neutralt eller negativt används en AddCashToPlayWith metoden. Se klassen AddCashToWallet klassen för mer info.*/
            if (p.PlayerWallet.CashCheck() <= 0)
                moneyDeposited = moneyDeposited + AddCashToWallet.AddCashToPlayWith(p); //moneySpent tilldelas det returnerade värdet. Detta används senare som statistik.

            //Nedanför påbörjas själva spelet. Om Q eller Quit skrivs in som svar vid valkontrollen avslutas loopen.
            Console.WriteLine("Choose 'Quit' if you want to quit.");
            while (!(input == "QUIT" || input == "Q"))
            {

                Console.WriteLine("Do you want to spin, " + p.Name + "? Yes/No");
                /*VALKONTROLL:
                 Här får spelaren välja att spela eller att avsluta sin omgång. 
                 Använder mig av en do-while loop som går vidare när ett korrekt alternativ valts.*/
                do input = Console.ReadLine().ToUpper();
                while (!(input == "Y" || input == "YES" || input == "N" || input == "NO" || input == "QUIT" || input == "Q"));
                //om Y eller Yes valts vid valkontrollen så körs nedanstående if funktion.
                if (input == "Y" || input == "YES")
                {
                    Console.Clear();
                    //detta meddelande visar hur mycket pengar som finns kvar spelarens plånbok.
                    Console.WriteLine("Balance: {0:f2}", p.PlayerWallet.CashCheck());
                    Console.Write("Place a bet:");

                    //en do-while loop som inväntar ett stringvärde som går att parsea ett double värde ur.
                    do input = Console.ReadLine();
                    while (!double.TryParse(input, out double i));
                    //När ett korrekt värde går att parsea görs det nedan och playerBet tilldelas det parseade värdet.
                    playerBet = double.Parse(input);

                    //Om det satsade värdet är mindre eller detsamma som _balance värdet i spelarens plånbok körs nedanstående if funktion.
                    if (playerBet <= p.PlayerWallet.CashCheck())
                    {
                        moneyLost = moneyLost + playerBet; //Statistiska variabeln moneyLost fångar upp det satsade värdet.
                        //Det satsade värdet dras från plånboken.
                        p.WithdrawCash(playerBet);
                        Console.WriteLine();

                        /*Det satsade värdet sätts in som argument i Game metoden under GameBoard klassen som Spinner klassen har ärvt. 
                         Game metoden returnerar sedan ett vinst värde. winnings variabeln tilldelas det returnerade värdet.*/
                        winnings = Game(playerBet);
                        //Om winnings har ett positivt värde(om spelaren vunnit pengar) skrivs ett vinstmeddelande ut.
                        if (winnings > 0)
                        {
                            Console.WriteLine("You won {0:N2}", +winnings + ", congratulations " + p.Name + "!");
                            //Vinst värdet läggs till i spelarens plånbok och statistik variabeln moneyWon fångar även upp värdet.
                            p.AddCash(winnings);
                            moneyWon = moneyWon + winnings;
                        }
                        else
                            //om winnings inte har ett positivt värde skrivs detta meddelande ut.
                            Console.WriteLine("No winning row");
                    }
                    /*Om det satsade värdet överstiger spelarens tillgängliga tillgångar skrivs det ut två meddelanden samt ett alternativ att lägga till mer pengar i plånboken. 
                     * Ett som meddelar att värdet är för högt gentemot spelarens tillgångar,
                     ett meddelande som visar hur mycket pengar som finns kvar i spelarens plånbok
                     och ett alternativ om man vill lägga till mer pengar i ens plånpok*/
                    else
                    {
                        Console.WriteLine("Not enough cash left in wallet to bet that high!");

                        Console.WriteLine("You have " + p.PlayerWallet.CashCheck() + " money left!");
                        Console.WriteLine("Do you want to add more money to your wallet? Y/N");
                        input = Console.ReadLine().ToUpper();
                        while (input == "Y" || input == "YES" || input == "NO" ||input =="N")
                            if (input == "Y" || input == "YES")
                            moneyDeposited = moneyDeposited + AddCashToWallet.AddCashToPlayWith(p);
                        if (input == "NO" || input == "N")
                            Console.WriteLine();
                    }

                }
                //om N eller No valts vid valkontrollen så körs nedanstående if funktion.
                if (input == "N" || input == "NO")
                {
                    Console.Clear();
                    //Här skrivs en rad ut som tackar spelaren för att hen har spelat.
                    if (moneyWon == moneyLost)
                        return "Well, that was pointless.";
                    else
                    {
                        Console.WriteLine("Thank you for playing, " + p.Name + "!");
                        /*Här jämförs moneyLost mot moneyWon variablerna. Beroende på vilken som är högst returneras specifika string värden. 
                         I stringarna sätts alla statistiska värden in, så spelaren får överseende över hur mycket som spelats för och hur mycket som vunnits/förlorats.
                         Använder mig av funktionen System.Environment.NewLine för att skapa nya rader i den returnerade stringen*/
                        if (moneyLost > moneyWon) // om förlust.
                            return string.Format("You spent: {0:N2}{1:N2}{2:N2}", moneyDeposited + " You Lost: ", moneyLost + " You won: ", moneyWon + "."+ System.Environment.NewLine +"Better luck next time, " + p.Name + ".");
                        if (moneyWon > moneyLost) // om vinst.
                            return string.Format("You spent: {0:N2}{1:N2}{2:N2}", moneyDeposited + " You Lost: ", moneyLost + " You won: ", moneyWon + "." +  System.Environment.NewLine +"Good run, " + p.Name + ". " + p.Country + " will celebrate your victory, to be sure!");
                    }

                }
                //om spelarens pengar tagit slut ges spelaren ett val att sätta in mer pengar eller avsluta sin spelrunda.
                if (p.PlayerWallet.CashCheck() <= 0)
                {
                    Console.WriteLine("Oh no " + p.Name + "! You lost all your money. Do you wish to insert more money to your wallet? Yes/No");
                    input = Console.ReadLine().ToUpper();
                    //Om Y/Yes väljs används den tidigare använda AddCashToPlayWith metoden. moneySpent tilldelas det insatta värdet även här.
                    if (input == "Y" || input == "YES")
                        moneyDeposited = moneyDeposited + AddCashToWallet.AddCashToPlayWith(p);
                    //Om N/No skrivs in så returneras en förlust string.
                    if (input == "N" || input == "NO")
                        return string.Format("You walk away a broken man, {0:N2}", p.PlayerWallet.CashCheck() + " money to your name! FeelsBadMan.");
                }
            }
            //Om spelaren väljer Q/Quit returneras denna string.
            return ("You chose to quit. You spent: " + moneyDeposited + " You Lost: " + moneyLost + " You won: " + moneyWon);


        }
    }
}


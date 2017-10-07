using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_3
{    
    class AddCashToWallet
    {/*Denna klass är till för att manuelt kunna lägga till pengar i spelarens plånbok. 
        Detta kan ske på tre platser i koden. När spelaren börjar spela, satsat mer än spelarens tillgångar och när spelarens pengar tagit slut.
        Metoden tar emot ett Player objekt som argument.*/       
        public static double AddCashToPlayWith(Player p)
        {
            int moneyAdded = 0;
            Console.WriteLine("How much money do you want to deposit to your wallet " + p.Name + "?");
            //tills det att ett giltigt värde satts in kommer funktionen inte gå vidare.
            while (moneyAdded <= 0)
            {
                int.TryParse(Console.ReadLine(), out int startUpCash);
                moneyAdded = startUpCash;
            }
                p.AddCash(moneyAdded);
            Console.Clear();
            Console.WriteLine("Good luck " + p.Name + "! You have added "+ moneyAdded + " money to your wallet!");
            //Metoden returnerar sedan en double som genom spelets gång summerar alla insättningar och skriver ut det som statistik vid spelets slut. Se Spinner Klassen.
            return moneyAdded;
        }
    }
}

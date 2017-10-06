using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_3
{
    class Wallet
    {
        // Denna variabel håller den valuta som spelaren har tillgång till att spela med. Den ändras med hjälp av metoder.
        private double _balance { get; set; }

        //En AddCash metod som helt enkelt lägger till värdet som sätts som argument till _balance variablen
        public void AddCash(double AddToBalance)
        {
            _balance = _balance + AddToBalance;
        }
        //En WithdrawCash metod som lika enkelt subtraherar från _balance värdet.
        public void WithdrawCash(double WithdrawFromBalance)
        {
            _balance = _balance - WithdrawFromBalance;
        }
        //en metod som returnerar _balance värdet. Använder den i koden för att se att t.ex. ens insatser inte överskrider ens tillgångar. 
        public double CashCheck()
        {
            return _balance;
        }
    }
}

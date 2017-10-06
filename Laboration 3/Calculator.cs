using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_3
{//Klassen är förälder till ArrayWinResult Klassen
    class Calculator
    {
        //metoden tar emot två double värden i form av money och multiply.
        protected double CashCalculator(double playerBet, double multiplyValue)
        {
           //returnerar money* multiply.
            return  playerBet * multiplyValue;
        }
    }
}

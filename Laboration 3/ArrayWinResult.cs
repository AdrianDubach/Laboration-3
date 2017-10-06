using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_3
{ //Denna klassen ärver Calculator klassens funktioner
    class ArrayWinResult : Calculator
    {
        private double returnValue;
        private double multiplyValue;
        public ArrayWinResult()
        {

        }
        /*Denna metod kontrollerar en array med storlek [3,3] om den har samma string värden på platser i antingen horisontell eller sluttande riktning. 
         Metoden tar även emot spelarens insats som senare används för att räkna ut hur mycket spelaren potentiellt vunnit.*/
        public double ArrayWinChecker(String[,] SpelKonsol, double playerBet)
        {
            multiplyValue = 0;
            // Kollar om översta raden har lika string värden.
            if (SpelKonsol[0, 0] == SpelKonsol[0, 1] && SpelKonsol[0, 0] == SpelKonsol[0, 2])
            { /*Dessa if satser kollar, om raden har ett värde, vilken string som är på första platsen.  
                Variabeln returnValue utökas i så fall med ett som tilldelas beroende på vilken string som finns på första array platsen.
                Denna funktion är densamma i alla följande radvinst-funktioner.*/
                if (SpelKonsol[0, 0] == "9")
                    multiplyValue += 2;
                if (SpelKonsol[0, 0] == "10")
                    multiplyValue += 3;
                if (SpelKonsol[0, 0] == "J")
                    multiplyValue += 4;
                if (SpelKonsol[0, 0] == "Q")
                    multiplyValue += 7;
                if (SpelKonsol[0, 0] == "K")
                    multiplyValue += 14;
                if (SpelKonsol[0, 0] == "D")
                    multiplyValue += 1337;
                /* Varje rad som har tre lika värden skriver ut ett meddelande i konsollen som följer samma struktur som detta meddelande. 
                   Meddelandet visar vilket värde som den vinnande raden innehåller genom att sätta in den första array platsen i den raden i utskriften.
                   Enda skillnaden mellan meddelandena är att dom anger vilken rad som vunnit */
                Console.WriteLine("Top row is a winner! Winning figure: " + SpelKonsol[0, 0]);
            }
            //Om mittersta raden har lika värden.
            if (SpelKonsol[1, 0] == SpelKonsol[1, 1] && SpelKonsol[1, 0] == SpelKonsol[1, 2])
            {
                if (SpelKonsol[1, 0] == "9")
                    multiplyValue += 2;
                if (SpelKonsol[1, 0] == "10")
                    multiplyValue += 3;
                if (SpelKonsol[1, 0] == "J")
                    multiplyValue += 4;
                if (SpelKonsol[1, 0] == "Q")
                    multiplyValue += 7;
                if (SpelKonsol[1, 0] == "K")
                    multiplyValue += 14;
                if (SpelKonsol[1, 0] == "D")
                    multiplyValue += 1337;
                Console.WriteLine("Middle row is a winner! Winning figure: " + SpelKonsol[1, 0]);
            }
            //om nedersta raden har lika värden.
            if (SpelKonsol[2, 0] == SpelKonsol[2, 1] && SpelKonsol[2, 0] == SpelKonsol[2, 2])
            {
                if (SpelKonsol[2, 0] == "9")
                    multiplyValue += 2;
                if (SpelKonsol[2, 0] == "10")
                    multiplyValue += 3;
                if (SpelKonsol[2, 0] == "J")
                    multiplyValue += 4;
                if (SpelKonsol[2, 0] == "Q")
                    multiplyValue += 7;
                if (SpelKonsol[2, 0] == "K")
                    multiplyValue += 14;
                if (SpelKonsol[2, 0] == "D")
                    multiplyValue += 1337;
                Console.WriteLine("Bottom row is a winner! Winning figure: " + SpelKonsol[2, 0]);
            }
            //om raden som har \ sluttning  har lika värde.
            if (SpelKonsol[0, 0] == SpelKonsol[1, 1] && SpelKonsol[0, 0] == SpelKonsol[2, 2])
            {
                if (SpelKonsol[0, 0] == "9")
                    multiplyValue += 2;
                if (SpelKonsol[0, 0] == "10")
                    multiplyValue += 3;
                if (SpelKonsol[0, 0] == "J")
                    multiplyValue += 4;
                if (SpelKonsol[0, 0] == "Q")
                    multiplyValue += 7;
                if (SpelKonsol[0, 0] == "K")
                    multiplyValue += 14;
                if (SpelKonsol[0, 0] == "D")
                    multiplyValue += 1337;
                Console.WriteLine("Split row top to lower is a winner! Winning figure: " + SpelKonsol[0, 0]);
            }
            //om raden som har / sluttning  har lika värde.
            if (SpelKonsol[2, 0] == SpelKonsol[1, 1] && SpelKonsol[2, 0] == SpelKonsol[0, 2])
            {
                if (SpelKonsol[2, 0] == "9")
                    multiplyValue += 2;
                if (SpelKonsol[2, 0] == "10")
                    multiplyValue += 3;
                if (SpelKonsol[2, 0] == "J")
                    multiplyValue += 4;
                if (SpelKonsol[2, 0] == "Q")
                    multiplyValue += 7;
                if (SpelKonsol[2, 0] == "K")
                    multiplyValue += 14;
                if (SpelKonsol[2, 0] == "D")
                    multiplyValue += 1337;
                Console.WriteLine("Split row lower to top is a winner! Winning figure: " + SpelKonsol[2, 0]);
            }
            //CashCalculator metoden som ärvts från Calculator klassen körs med playerBet och multiplyValue variablerna som argument. Resultatet returneras sedan vidare.
            returnValue = CashCalculator(playerBet, multiplyValue);
            return returnValue;
        }
    }
}

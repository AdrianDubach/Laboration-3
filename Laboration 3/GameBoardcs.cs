using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_3
{ //GameBoard ärver funktionerna i SetGameBoardIdentity
    class GameBoard : SetGameBoardIdentity
    {
        private double returnValue;
        private int boardSize;
        ArrayWinResult CheckIfWin;

        protected GameBoard()
        {
            CheckIfWin = new ArrayWinResult();
            returnValue = 0;
        }
        //I denna metod genereras själva spelrutan som avgör om spelaren vinner eller förlorar pengar. Funktioner gås igenom stegvis.
        protected double Game(double playerBet)
        {
            //storleken på spelrutan bestäms.
            boardSize = 3;
            //en två-dimensionell array skapas som använder boardSize variabeln för sin längd och bredd.
            String[,] SpelKonsol = new String[boardSize, boardSize];
            // en dubbel for-loop används för att sätta ut alla värden i multi-arrayen. **Looparna använder sig också av boardSize variabeln.
            for (int i = 0; i < boardSize; i++)
            {
                
                for (int j = 0; j < boardSize; j++)
                {/*För varje gång denna loop körs så används SetBlockValue metoden under SetGameBoardIdentity klassen som GameBoard ärvt.
                    Det metoden gör är att den returnerar en string som sätts in i den plats i arrayen som loopen körs igenom
                    Enkelt förklarat: För varje i loop körs j loopen 3 gånger. Varje gång j loopen körs tilldelas platsen [i, j] i arrayen den returnerade stringen
                    Så om i körts en gång och j två gånger så ser array placeringern ut som sådan[0, 1]*/
                    SpelKonsol[i, j] = SetBlockValue();
                    //Denna skriver ut värdena som tilldelas arrayen på en rad i konsollen.
                    Console.Write("\t{0}\t", SpelKonsol[i, j]);

                }
                //när j loopen körts klar avslutar i loopen med att skapa en ny rad.
                Console.WriteLine();
            }
            Console.WriteLine();
            /*När arrayen tilldelats alla värden genom dubbel for-loopen sätts den, samt spelarens insatts in som argument i ArrayWinChecker metoden under ArrayWinResult klassen. 
             Ett värde returneras sedan till returnValue variabeln.*/
            returnValue = CheckIfWin.ArrayWinChecker(SpelKonsol, playerBet);
            return returnValue;
        }
    }
}

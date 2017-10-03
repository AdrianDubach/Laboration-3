using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_3
{
    class GameBoard
    {

        public static double Game(double playerMoney)
        {
            double returnValue = 0;
            double multiplyValue = 0;
            int boardLength = 3;
            String[,] SpelKonsol = new String[boardLength, boardLength];
            for (int i = 0; i < boardLength; i++)
            {
                
                for (int j = 0; j < boardLength; j++)
                {
                    SpelKonsol[i, j] = RandomToIdentity.BlockPicker();
                    Console.Write("\t{0}\t", SpelKonsol[i, j]);

                }
                Console.WriteLine();
            }
            Console.WriteLine();
            multiplyValue = ArrayWinResult.ArrayWinChecker(SpelKonsol);
            returnValue = Calculator.CashCalculator(playerMoney, multiplyValue);
            return returnValue;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_3
{
    class ArrayWinResult
    {
        public static double ArrayWinChecker(String[,] SpelKonsol)
        {
            double returnValue = 0;
            if (SpelKonsol[0, 0] == SpelKonsol[0, 1] && SpelKonsol[0, 0] == SpelKonsol[0, 2])
            {
                if (SpelKonsol[0, 0] == "9")
                    returnValue += 2;
                if (SpelKonsol[0, 0] == "10")
                    returnValue += 3;
                if (SpelKonsol[0, 0] == "J")
                    returnValue += 4;
                if (SpelKonsol[0, 0] == "Q")
                    returnValue += 7;
                if (SpelKonsol[0, 0] == "K")
                    returnValue += 14;
                if (SpelKonsol[0, 0] == "D")
                    returnValue += 1337;
            }
            if (SpelKonsol[1, 0] == SpelKonsol[1, 1] && SpelKonsol[1, 0] == SpelKonsol[1, 2])
            {
                if (SpelKonsol[1, 0] == "9")
                    returnValue += 2;
                if (SpelKonsol[1, 0] == "10")
                    returnValue += 3;
                if (SpelKonsol[1, 0] == "J")
                    returnValue += 4;
                if (SpelKonsol[1, 0] == "Q")
                    returnValue += 7;
                if (SpelKonsol[1, 0] == "K")
                    returnValue += 14;
                if (SpelKonsol[1, 0] == "D")
                    returnValue += 1337;
            }
            if (SpelKonsol[2, 0] == SpelKonsol[2, 1] && SpelKonsol[2, 0] == SpelKonsol[2, 2])
            {
                if (SpelKonsol[2, 0] == "9")
                    returnValue += 2;
                if (SpelKonsol[2, 0] == "10")
                    returnValue += 3;
                if (SpelKonsol[2, 0] == "J")
                    returnValue += 4;
                if (SpelKonsol[2, 0] == "Q")
                    returnValue += 7;
                if (SpelKonsol[2, 0] == "K")
                    returnValue += 14;
                if (SpelKonsol[2, 0] == "D")
                    returnValue += 1337;
            }
            if (SpelKonsol[0, 0] == SpelKonsol[1, 1] && SpelKonsol[0, 0] == SpelKonsol[2, 2])
            {
                if (SpelKonsol[0, 0] == "9")
                    returnValue += 2;
                if (SpelKonsol[0, 0] == "10")
                    returnValue += 3;
                if (SpelKonsol[0, 0] == "J")
                    returnValue += 4;
                if (SpelKonsol[0, 0] == "Q")
                    returnValue += 7;
                if (SpelKonsol[0, 0] == "K")
                    returnValue += 14;
                if (SpelKonsol[0, 0] == "D")
                    returnValue += 1337;
            }
            if (SpelKonsol[2, 0] == SpelKonsol[1, 1] && SpelKonsol[2, 0] == SpelKonsol[0, 2])
            {
                if (SpelKonsol[2, 0] == "9")
                    returnValue += 2;
                if (SpelKonsol[2, 0] == "10")
                    returnValue += 3;
                if (SpelKonsol[2, 0] == "J")
                    returnValue += 4;
                if (SpelKonsol[2, 0] == "Q")
                    returnValue += 7;
                if (SpelKonsol[2, 0] == "K")
                    returnValue += 14;
                if (SpelKonsol[2, 0] == "D")
                    returnValue += 1337;
            }
            return returnValue;
        }
    }
}

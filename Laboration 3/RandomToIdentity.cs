using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_3
{
    class RandomToIdentity
    {
        static int picker;
        static string result;
        static Random rnd = new Random();
        public RandomToIdentity()
        {
            picker = 0;
            result = null;
        }

        public static string BlockPicker()
        {
            picker = rnd.Next(1, 101);

            if (picker > 0 && picker < 3)
                result = "D";
            if (picker > 2 && picker < 11)
                result = "K";
            if (picker > 10 && picker < 26)
                result = "Q";
            if (picker > 25 && picker < 46)
                result = "J";
            if (picker > 45 && picker < 71)
                result = "10";
            if (picker > 70 && picker <= 100)
                result = "9";

            return result;
        }
    }
}

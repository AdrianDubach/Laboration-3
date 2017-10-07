using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_3
{ //Denna klass är förälder till GameBoard Klassen.
    class SetGameBoardIdentity
    {
       
         private int picker;
         private string result;
         private Random rnd;

        protected SetGameBoardIdentity()
        {
            rnd = new Random();
            picker = 0;
            result = null;
        }
        // denna metod använder sig av en random variabel som avgör vilken string som returneras.
        protected string SetArrayPosValue()
        {
            //picker variabeln tilldelas ett random värdet från 1 till 100.
            picker = rnd.Next(1, 101);
            /*nedanför följer en rad if satser som väljs beroende på vilket värde picker variabeln givits. 
             När korrekt if sats valts ges result variabeln ett string värde som därefter returneras*/
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

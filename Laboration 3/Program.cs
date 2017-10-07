using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_3
{
    /* Creator of the Nexus 6 project: Adrian Dubach
     
         Noter: Jag har på eget initiativ använt mig av ärvda klasser i koden. Detta då jag råkade läsa lite om det och tyckte det verkade smidigare gentemot att
         generera nya objekt för varje klass. Resultatet blev en, enligt mig, säkrare kod där klasserna har mindre yttre tillgång samt ett halverande av objekt skapande osv.
         Använder tillgänglighetsnivån 'protected' på föräldraklasserna vilket innebär
         att dess funktioner endast kan fås tillgång till via samma klass samt klasser som ärver klassens funktioner*/

        //Program ärver funktioner från InitPlayer klassen.
    class Program : InitPlayer
    {
        private static string moneyStats;

        static void Main(string[] args)
        {/*Ett player objekt skapas med hjälp av en metod i InitPlayer klassen som heter NewPlayer. 
            Då initklassen ärvts behövs bara referns till metoden. */
            Player Newbie = NewPlayer();
            //en ny instans av Spinner klassen skapas.
            Spinner NewSpin = new Spinner();
            /*Här kollas att Age variabeln i Player objektet har ett lovligt värde. 
              Om värdet är olovligt slängs en egenkonstruerad Exception med tillhörande argument. */
            try
            {
                if (Newbie.Age < 18) throw new AgeException("Too young!");
                if (Newbie.Age > 70) throw new AgeException("Too Old!");
                /*Här körs programmets huvudfunktioner igång. 
                 *moneyStats variabeln fångar, vid spelets slut, upp en rad statistik i form av en string. Detta skrivs slutligen ut. 
                 Notera att det skapade Player objektet används som argument.*/
                moneyStats = NewSpin.Spin(Newbie);
                Console.WriteLine(moneyStats);
            }

            /*En catch metod som enbart fångar upp den sorts exception som jag skapat. 
              Den skriver också ut det som satts in som argument i Exceptionen. */
            catch (AgeException ageExc)
            {
                Console.WriteLine(ageExc.Message);
            }

            Console.Read();
        }
    }
}

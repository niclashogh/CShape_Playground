using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShape_Playground.Variable
{
    public class _Char
    {
        public void IdentifyCharType(char rawInput)
        {
            //Variables
            //rawInput = Console.ReadKey(true).KeyChar; //Sets the rawInput = a new user input

            if (Char.IsDigit(rawInput))
            {
                Console.WriteLine($"Du trykkede '{rawInput}' hvilket er et tal.");
            }
            else
                Console.WriteLine($"Du trykkede '{rawInput}' hvilket er et bokstav.");
        }

        public void FindChar()
        {
            //Variables
            string dummy = "abcdefghijklmnopqrstuvxyz";

            Console.WriteLine("\nDet 20. bokstav i alfabetet er '{0}'.", dummy[20]);
        }

    }
}

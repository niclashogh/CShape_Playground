using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShape_Playground.Variable
{
    public class _Int
    {
        public void TypeCasting(int rawInput)
        {
            //Variables
            int dummyNumber = rawInput - 2;

            Console.WriteLine($"Bruger input : {rawInput}");

            Console.WriteLine("\nTypeCasting : {0} / {1} = {2}", rawInput, dummyNumber, ((double)rawInput / (double)dummyNumber));
            Console.WriteLine("\nNo Casting : {0} / {1} = {2}\n", rawInput, dummyNumber, (rawInput / dummyNumber));
        }

        public void IntParse()
        {
            //Variables
            string numString;
            int numInt;
            bool loopState = false;

            //Loop
            do
            {
                Console.WriteLine("Using 'Int.Parse'");
                Console.Write("Angiv et tal: ");
                numString = Console.ReadLine();

                try
                {
                    numInt = int.Parse(numString);
                    Console.WriteLine($"Konverteret inputtet til en int : {numInt}");
                    loopState = false;
                }
                catch (Exception e)
                {
                    loopState = true;
                    Console.WriteLine(e.Message);
                    Console.WriteLine("\nAfventer enter!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            while (loopState);
        }
    }
}

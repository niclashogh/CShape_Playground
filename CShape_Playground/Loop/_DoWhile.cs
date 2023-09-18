
namespace CShape_Playground.Loop
{
    public class _DoWhile
    {
        public static void Method()
        {
            //Variables
            string input = "Jeg";
            int loop = 0;
            int loopEnd = 5;

            do //Goes thrugh one run and checks if it needs to run again.
            {
                Console.WriteLine(input);
                loop++;

                if (loop == loopEnd - 1) //Writes agressively on last loop
                    input += " har brug for at du sætter mig i fucking stik-kontakten, er det forstået din forpulede abeknepper?!";
            }
            while (loop < loopEnd);
        }
    }
}


namespace CShape_Playground.Loop
{
    public class _While
    {
        public static void Method()
        {
            //Variables
            int loop = 0;
            string inputString = "";

            //GetInput
            Console.Write("Skive en sætning/et ord: ");
            inputString = Console.ReadLine();

            //Loop
            while (loop < inputString.Length) //If false then skip while-method
            {
                Console.WriteLine(inputString[loop]);
                Thread.Sleep(500);
                loop++;
            }

        }
    }
}

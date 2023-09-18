
namespace CShape_Playground.Array
{
    public class FindOccaurance
    {
        public void Main()
        {
            //Variables
            int guess;
            bool failed = true;

            //Create array
            int[] array = new int[] { 1, 2, 5, 6, 8, 9 };

            //User-input
            Console.Write("Gæt et tal mellem 0-10: ");
            guess = int.Parse(Console.ReadLine());

            //For-loop
            for (int i = 0; i < array.Length; i++) //Runs through the entire array
            {
                if (guess == array[i]) //Evaluate if any of the 'run-through' turns == our guess
                {
                    Console.WriteLine("Du valgte et eksisterende tal!");
                    failed = false;
                }
            }
            //If statement
            if (failed == true)
            {
                Console.WriteLine("Tilykke, du valgte ikke et eksisterende tal!");
            }
        }
    }
}

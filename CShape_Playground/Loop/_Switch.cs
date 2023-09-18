
namespace CShape_Playground.Loop
{
    public class _Switch
    {
        public static void Method()
        {
            Console.WriteLine("Røv eller patter?");
            string choise = Console.ReadLine();

            switch (choise)
            {
                case "Røv":
                case "røv":
                    Console.WriteLine("Bunda!");
                    break;

                case "Patter":
                case "patter":
                    Console.WriteLine("Titas!");
                    break;

                default:
                    Console.WriteLine("Hvorfor er du sådan?");
                    break;
            }
        }
    }
}

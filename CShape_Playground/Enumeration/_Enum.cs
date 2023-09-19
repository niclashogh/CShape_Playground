
namespace CShape_Playground.Enumeration
{
    enum TraficLight { Red, Yellow, Green };

    public class _Enum
    {
        public void Method()
        {
            TraficLight light = TraficLight.Red; //New instance and init
            TraficLight light2 = TraficLight.Green; //New instance and init

            Console.WriteLine($"String Values: {light}, {light2}");
            Console.WriteLine($"\nCasting to int: {(int)TraficLight.Red} = {TraficLight.Red}");

            Console.ReadLine();
        }
    }
}

using System.Collections;

namespace CShape_Playground.Array
{
    public class _ArrayList
    {
        public void Main()
        {
            //Instances of class Car
            Car car1 = new Car();
            car1.Launched = "1978";
            car1.Model = "Fiat";

            Car car2 = new Car();
            car2.Launched = "2001";
            car2.Model = "Wolvo";


            //Old way of making a list
            ArrayList aList = new ArrayList();
            aList.Add(car1);
            aList.Add(car2);

            Console.WriteLine("Liste (Array):");

            //Foreach loop, Printout
            foreach (object obj in aList)
            {
                Console.WriteLine("Bil '{0}' blev lanceret i {1}", ((Car)obj).Model, ((Car)obj).Launched);
            }
        }
    }

    internal class Car
    {
        public string Launched { get; set; }
        public string Model { get; set; }
    }
}

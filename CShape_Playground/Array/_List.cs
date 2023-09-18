
namespace CShape_Playground.Array
{
    public class _List
    {
        public void Main()
        {
            //Instances of class Car
            Car car1 = new Car() { Launched = "1978", Model = "Fiat" }; //Car Class in arrayList.cs
            Car car2 = new Car() { Launched = "2001", Model = "Wolvo" };

            //Better method to making a list
            List<Car> sList = new List<Car>();
            sList.Add(car1);
            sList.Add(car2);

            sList.Remove(car1);

            Console.WriteLine("Liste (List):");

            //Foreach instance of the specific obj (Car).
            foreach (Car inst in sList) //Foreach instance of Car in sList. inst = variable to temp save the instances of Car(s).
            {
                Console.WriteLine("{0}, {1}", inst.Model, inst.Launched); //No casting required because we specified a generic list to Car.
            }

        }
    }
}

using System.Collections.Specialized;

namespace CShape_Playground.Array
{
    public class _ListDictonary
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

            //Another old way of making a list
            ListDictionary aDictionary = new ListDictionary();
            aDictionary.Add(car1.Launched, car1); //Contains a key and a value associated with it.
            aDictionary.Add(car2.Launched, car2); //The key is the instance that will allow us to refrence to the associated data.
                                                  //Eg. above: the car.Make is the key, so if we seach in the array for instances of .Make it will use the instance of that key.

            Console.WriteLine("Liste (ListDictionary):");

            //Printout
            Console.WriteLine("Bilen '{0}' matchede lanceringsåret 2001", ((Car)aDictionary["2001"]).Model); //Casting the object to car and retrives Car.Model

        }
    }
}

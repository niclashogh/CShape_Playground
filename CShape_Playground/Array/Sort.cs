using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShape_Playground.Array
{
    public class Sort
    {
        public void Main()
        {
            //Variables
            int[] array = { 4, 5, 7, 1, 3, 8, 3 };
            int tempStore;
            bool sortLow = false;
            string sortMethod;

            //Present options
            Console.WriteLine("Sorter liste med 'laveste' eller 'højeste' først.");
            Console.Write("Vælg sortering: ");
            sortMethod = Console.ReadLine();

            //Options
            switch (sortMethod)
            {
                case "laveste":
                case "Laveste":
                    {
                        sortLow = true;
                        break;
                    }
                case "højeste":
                case "Højeste":
                    {
                        sortLow = false;
                        break;
                    }
            }

            //Sorting
            for (int first = 0; first < array.Length; first++) //Find the first number in the array
            {
                for (int sec = first + 1; sec < array.Length; sec++) //Find the secound number in the array
                {
                    if (sortLow == false) //Testfor sortLow method
                    {
                        if (array[first] < array[sec]) //Compare the two - If the first is lower than the sec
                        {
                            tempStore = array[first]; //Saves the first number temperary
                            array[first] = array[sec]; //Puts the sec number into the first
                            array[sec] = tempStore; //Puts the first number into the sec
                        }   //Above is a switch function
                    }
                    else //If sortLow is true
                    {
                        if (array[first] > array[sec]) //Testfor : first > sec
                        {
                            tempStore = array[first];
                            array[first] = array[sec];
                            array[sec] = tempStore;
                        }
                    }

                }
            }
            foreach (var item in array)
            {
                Console.WriteLine(item); //Prints every item out (sortet)
            }

        }
    }
}

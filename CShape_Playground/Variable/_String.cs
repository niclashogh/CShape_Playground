using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShape_Playground.Variable
{
    public class _String
    {
        public void Index(string rawInput) //Method
        {
            //Variables
            int wordIndex = rawInput.IndexOf(" ") + 1; //Find wordIndex +1 (to skip the space) - only nessecary to skip bc we want to skip the space in this case
            string stringAtIndex = rawInput.Substring(0, wordIndex); //Prints Substring from space 0 = "start of wordIndex" to end = "wordIndex"
            int wordEndIndex = stringAtIndex.Length - 1; // Finds length of stringAtIndex -1 (the space)

            Console.WriteLine($"\nDet 2. ord i sætningen er '{rawInput.Substring(wordIndex, wordEndIndex)}'\nOrdets placering = {wordIndex}\nOrdets længde = {wordEndIndex}.");
        } //Could also be achived with .Split(' ') & string[]

        public void Contains(string rawInput) //Method
        {
            //Variables
            string detectKeyWord = "at"; //Field

            //else-if
            if (rawInput.Contains(detectKeyWord)) //Call internal Method
            {
                Console.WriteLine($"\nTeksen inderholder ordet '{detectKeyWord}'."); //Field
            }
            else
                Console.WriteLine($"\nTeksen inderholder ikke ordet '{detectKeyWord}'."); //Field
        }

        public void Lenghts(string rawInput) //Method
        {
            //Variables & Arrays
            string[] wordLenghts = rawInput.Split(' ');
            int longestWordInt = 0;
            string longestWord = null;

            //Loop
            foreach (string word in wordLenghts)
            {

                if (word.Length > longestWordInt)
                {
                    longestWordInt = word.Length;
                    longestWord = word;
                }
            }

            Console.WriteLine($"\nEt af de/Det længeste ord er : '{longestWord}' med i alt '{longestWordInt}' bokstaver.");
        }

        public void CharIndex(string rawInput) //Method
        {
            //Variables
            int charIndex = 15;

            Console.WriteLine($"\nBokstavet på placeringen '{charIndex}' er '{rawInput[charIndex]}'.");
        }

        public void DoubleSplit() //Method
        {
            //Variables & Arrays
            string dataSet = "Solid;Gas;Liquid*Missionary;Doggy;Classic Rape*Keyboard;Mouse;Screen;Cabinet";
            string[] splitSections = dataSet.Split('*');
            int sectionInt = 0;

            //Print dataSet
            Console.WriteLine($"\nDatasæt : {dataSet}");

            //Loop
            foreach (string value in splitSections)
            {
                Console.WriteLine();
                int elementInt = 0;
                string[] splitElements = splitSections[sectionInt].Split(';');

                foreach (string value1 in splitElements)
                {
                    Console.WriteLine($"{splitElements[elementInt]}");
                    elementInt++;
                }
                sectionInt++;
            }
        }
    }
}

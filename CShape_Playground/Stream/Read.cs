using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShape_Playground.Stream
{
    public class Read
    {
        public static string TXTPath = "..\\..\\..\\Stream\\Data.txt";
        public static string CSVPath = "..\\..\\..\\Stream\\Data.csv";
        public static string EXCELPath = "..\\..\\..\\Stream\\Data.xlsx";

        public void ReadTXT()
        {
            //Variables
            string getContent;

            Console.WriteLine(".TXT Datasættet indeholder:");

            if (!File.Exists(TXTPath))
            {
                Console.WriteLine("File does not exist!");
                return;
            }
            else
            {
                try
                {
                    //Instanciate method
                    StreamReader readConent = new StreamReader(TXTPath);

                    //Read the first line
                    getContent = readConent.ReadLine();

                    //Read-all
                    while (getContent != null)
                    {
                        Console.WriteLine(getContent);
                        getContent = readConent.ReadLine();
                    }
                    readConent.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public void ReadCSV()
        {
            //Variables
            int i = 0;

            Console.WriteLine(".CSV Datasættet indeholder:");

            if (!File.Exists(CSVPath))
            {
                Console.WriteLine("File does not exist!");
                return;
            }
            else
            {
                try
                {
                    //Instanciate method
                    StreamReader readConent = new StreamReader(CSVPath);

                    //use string[] split to check how many colums(';') & rows('\n') there is

                    //Split >> Problem
                    while (!readConent.EndOfStream)
                    {
                        string splitLine = readConent.ReadLine().Split('\n').ToString();
                        Console.WriteLine(splitLine[i]); //Delete when method is working

                        string[] splitBreak = splitLine.Split(';');
                        Console.WriteLine(splitBreak[i]);
                        i++;
                        Console.WriteLine(splitBreak[i]);
                    }
                    readConent.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public void ReadXLSX()
        {

        }
    }
}

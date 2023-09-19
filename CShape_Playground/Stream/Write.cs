using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace CShape_Playground.Stream
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Write
    {
        public static string TXTPath = "..\\..\\..\\Stream\\Data.txt";
        public static string CSVPath = "..\\..\\..\\Stream\\Data.csv";
        public static string EXCELPath = "..\\..\\..\\Stream\\Data.xlsx";

        public void WriteTXT()
        {
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
                    StreamWriter passContent = new StreamWriter(TXTPath, true, Encoding.ASCII); //true = Don't replace data

                    //Write w/ newline
                    passContent.WriteLine("Hello there");

                    //Write w/ newline
                    passContent.WriteLine("(:^P)-I--<");

                    Console.WriteLine("Det lykkes at skrive til datasættet (.TXT)");

                    //Close StreamWriter
                    passContent.Close();
                }
                finally
                {
                    //
                }
            }
        }

        public void WriteCSV()
        {
            //Variables


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
                    StreamWriter passContent = new StreamWriter(CSVPath, true, Encoding.ASCII); //true = Don't replace data

                    //Write w/ newline
                    passContent.WriteLine("B003;Ovn");

                    Console.WriteLine("Det lykkes at skrive til datasættet (.CSV)");

                    //Close StreamWriter
                    passContent.Close();
                }
                finally
                {
                    //
                }
            }

        }

        public void WriteXLSX()
        {
            //Decalraition
            var familyMembers = new List<Person>
            {
                new Person { Name = "Karoline", Age = 15},
                new Person { Name = "Matilde", Age = 20},
                new Person { Name = "Niclas", Age = 22 },
                new Person { Name = "Hanne", Age = 43},
                new Person { Name = "Kenned", Age = 43}
            };

            //Creates and opens a new Excel
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            
            //excel.DefaultFilePath = EXCELPath;

            //New instance
            excel.Workbooks.Add();

            //Column ID
            excel.Cells[1, "A"] = "Names";
            excel.Cells[1, "B"] = "Ages";

            //Print 'Person'
            int row = 1;

            foreach (var inst in familyMembers)
            {
                row++;
                excel.Cells[row, "A"] = inst.Name;
                excel.Cells[row, "B"] = inst.Age;
            }

            //close and save...

        }
    }
}

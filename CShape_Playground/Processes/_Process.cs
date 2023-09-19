using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShape_Playground.Processes
{
    public class _Process
    {
        public void Method(string[] args)
        {
            bool running = true;
            string programName = "CShape_Playground"; // skal hedde det same som 
                                            // projektet

            if (args.Length == 0)
            {
                Console.Write("Indtast antal processer, der skal startes : ");
                int antal = int.Parse(Console.ReadLine());
                for (int i = 0; i < antal; i++)
                {
                    Console.WriteLine($"Starter proces {i}");
                    Process process = new Process();
                    process.StartInfo.FileName = programName;
                    process.StartInfo.Arguments = "\"" + programName + $", version {i}" + "\"";
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                    process.Start();
                }
            }
            else
            {
                int current = 0;
                const int number = 5000;
                const int sleeptime = 5;
                while (running)
                {
                    current++;
                    Console.WriteLine(args[0] + $", counting to {number}....: " + current);
                    Thread.Sleep(sleeptime);
                    running = (current < number);
                }
            }
        }
    }
}

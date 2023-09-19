using CShape_Playground.Array;
using CShape_Playground.Enumeration;
using CShape_Playground.Loop;
using CShape_Playground.Processes;
using CShape_Playground.Scheduling;
using CShape_Playground.Stream;
using CShape_Playground.Threading;
using CShape_Playground.Variable;

namespace CShape_Playground
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Manual Config
            Namespace_Array(0, false, true);
            Namespace_Delegate(true);
            Namespace_ObserverPattern(true);
            Namespace_Enum(true);
            Namespace_Loop(0, false, true); //Not Complete
            Namespace_Process(args, true);
            Namespace_Scheduling(true); //Idk ...
            Namespace_Stream(5, false, true); //Not Complete
            Namespace_Threading(false); //Not Complete
            Namespace_Variable(0, false, true);
            
        }

        internal static void Namespace_Array(int section, bool runAll, bool skipNamespace)
        {
            if (skipNamespace) return;

            _ArrayList _arrayList = new();
            if (section == 0 || runAll)
            {
                _arrayList.Main();
                Console.ReadLine();
                Console.Clear();
            }

            _Dictionary _dictionary = new();
            if (section == 1 || runAll)
            {
                _dictionary.Main();
                Console.ReadLine();
                Console.Clear();
            }

            _List _list = new();
            if (section == 2 || runAll)
            {
                _list.Main();
                Console.ReadLine();
                Console.Clear();
            }

            _ListDictonary _listDictonary = new();
            if (section == 3 || runAll)
            {
                _listDictonary.Main();
                Console.ReadLine();
                Console.Clear();
            }

            FindOccaurance _findOccaurance = new();
            if (section == 4 || runAll)
            {
                _findOccaurance.Main();
                Console.ReadLine();
                Console.Clear();
            }

            Array.Math _math = new();
            if (section == 5 || runAll)
            {
                _math.Avg();
                Console.ReadLine();
                Console.Clear();
            }

            Sort _sort = new();
            if (section == 6 || runAll)
            {
                _sort.Main();
                Console.ReadLine();
                Console.Clear();
            }
        }

        internal static void Namespace_Delegate(bool skipNamespace)
        {
            if (skipNamespace) return;

            //Init new Publicher
            Delegate.Publicher p1 = new("Pub 1");

            //Init new Subscribers
            Delegate.Subscriber s1 = new("Sub 1");
            Delegate.Subscriber s2 = new("Sub 2");
            Delegate.Subscriber s3 = new("Sub 3");

            //Add Subscribers
            p1.BroadCast += s1.BroadCastItem;
            p1.BroadCast += s2.BroadCastItem;
            p1.BroadCast += s3.BroadCastItem;

            //Broadcast item
            p1.BroadCastItem = "PSA: Don't do it";

            //Await
            Console.ReadLine();
            Console.Clear();
        }

        internal static void Namespace_ObserverPattern(bool skipNamespace)
        {
            if (skipNamespace) return;

            //Init Publicher
            var p1 = new Observer_Pattern.Publicher("Publicher 1");

            //Init Subscriber
            var s1 = new Observer_Pattern.Subscriber(p1, "Sub 1");
            var s2 = new Observer_Pattern.Subscriber(p1, "Sub 2");
            var s3 = new Observer_Pattern.Subscriber(p1, "Sub 3");

            //Asign Subscribers
            p1.Attach(s1);
            p1.Attach(s2);
            p1.Attach(s3);

            //Broadcast Item
            p1.BroadCastItem = "PSA: Drink!";

            p1.Detach(s2);
            p1.BroadCastItem = "PSA: Drink more!";

            //Await
            Console.ReadLine();
            Console.Clear();

        }

        internal static void Namespace_Enum(bool skipNamespace)
        {
            if (skipNamespace) return;

            _Enum _enum = new();
            _enum.Method();
        }

        internal static void Namespace_Loop(int section, bool runAll, bool skipNamespace)
        {
            if (skipNamespace) return;

            // Do-While
            if (section == 0 || runAll)
            {
                _DoWhile.Method();
                Console.ReadLine();
                Console.Clear();
            }

            // Switch
            if (section == 1 || runAll)
            {
                _Switch.Method();
                Console.ReadLine();
                Console.Clear();
            }

            // While
            if (section == 2 || runAll)
            {
                _While.Method();
                Console.ReadLine();
                Console.Clear();
            }
        }

        internal static void Namespace_Variable(int section, bool runAll, bool skipNamespace)
        {
            if (skipNamespace) return;

            _Char _char = new();
            if (section == 0 || runAll)
            {
                Console.WriteLine("Press a key");
                _char.IdentifyCharType((Char)Console.Read());
                _char.FindChar();
                Console.ReadLine();
                Console.Clear();
            }

            _DataTime _dateTime = new();
            if (section == 1 || runAll)
            {
                _dateTime.CurrentDate(DateTime.Now);
                _dateTime.RelativeDate(DateTime.Now);
                _dateTime.SpanDate(DateTime.Now);
                Console.ReadLine();
                Console.Clear();
            }

            _String _string = new();
            string input = "Der skal ikke meget til at man en dag sidder med lort ned af benet";
            if (section == 2 || runAll)
            {
                _string.Index(input);
                _string.Contains(input);
                _string.Lenghts(input);
                _string.CharIndex(input);
                _string.DoubleSplit();
                Console.ReadLine();
                Console.Clear();
            }

            _Int _int = new();
            if (section == 3 || runAll)
            {
                _int.TypeCasting(15);
                _int.IntParse();
            }

        }

        internal static void Namespace_Process(string[] args, bool skipNamespace)
        {
            if (skipNamespace) return;

            _Process _process = new();
            _process.Method(args);

        }

        internal static void Namespace_Scheduling(bool skipNamespace)
        {
            if (skipNamespace) return;

            PCB pcb = new("Hacking", 1);
            PCB.Retrieve(pcb);

            Console.WriteLine(pcb.ToString());
            Console.ReadLine();
        }

        internal static void Namespace_Stream(int section, bool runAll, bool skipNamespace)
        {
            if (skipNamespace) return;

            Read read = new();
            // TXT
            if (section == 0 || runAll)
            {
                read.ReadTXT();
            }

            // CSV
            if (section == 1 || runAll)
            {
                read.ReadCSV();
            }

            // XLSX
            if (section == 2 || runAll)
            {
                read.ReadXLSX();
            }

            Write write = new();
            // TXT
            if (section == 3 || runAll)
            {
                write.WriteTXT();
            }

            // CSV
            if (section == 4 || runAll)
            {
                write.WriteCSV();
            }

            // XLSX
            if (section == 5 || runAll)
            {
                write.WriteXLSX();
            }
        }

        internal static void Namespace_Threading(bool skipNamespace)
        {
            if (skipNamespace) return;

            _Threading _threading = new();
            _threading.Method();
        }
    }
}
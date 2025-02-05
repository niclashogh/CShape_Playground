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
            Namespace_Array();
            Namespace_Delegate();
            Namespace_ObserverPattern();
            Namespace_Enum();
            Namespace_Loop(); //Not Completed
            Namespace_Process(args);
            Namespace_Scheduling(); //Idk ...
            Namespace_Stream(); //Not Completed
            Namespace_Threading(); //Not Completed
            Namespace_Variable();
            Namespace_Async(); //Not Completed
            Namespace_Socket(); //Not Complted
            
        }

        internal static void Namespace_Array()
        {
            _ArrayList _arrayList = new();
            _arrayList.Main();
            Console.ReadLine();
            Console.Clear();

            _Dictionary _dictionary = new();
            _dictionary.Main();
            Console.ReadLine();
            Console.Clear();
            

            _List _list = new();
            _list.Main();
            Console.ReadLine();
            Console.Clear();

            _ListDictonary _listDictonary = new();
            _listDictonary.Main();
            Console.ReadLine();
            Console.Clear();

            FindOccaurance _findOccaurance = new();
            _findOccaurance.Main();
            Console.ReadLine();
            Console.Clear();

            Array.Math _math = new();
            _math.Avg();
            Console.ReadLine();
            Console.Clear();

            Sort _sort = new();
            _sort.Main();
            Console.ReadLine();
            Console.Clear();
        }

        internal static void Namespace_Delegate()
        {
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

        internal static void Namespace_ObserverPattern()
        {
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

        internal static void Namespace_Enum()
        {
            _Enum _enum = new();
            _enum.Method();
        }

        internal static void Namespace_Loop()
        {
            // Do-While
            _DoWhile.Method();
            Console.ReadLine();
            Console.Clear();

            // Switch
            _Switch.Method();
            Console.ReadLine();
            Console.Clear();

            // While
            _While.Method();
            Console.ReadLine();
            Console.Clear();
        }

        internal static void Namespace_Variable()
        {
            _Char _char = new();
            Console.WriteLine("Press a key");
            _char.IdentifyCharType((Char)Console.Read());
            _char.FindChar();
            Console.ReadLine();
            Console.Clear();

            _DataTime _dateTime = new();
            _dateTime.CurrentDate(DateTime.Now);
            _dateTime.RelativeDate(DateTime.Now);
            _dateTime.SpanDate(DateTime.Now);
            Console.ReadLine();
            Console.Clear();

            _String _string = new();
            string input = "Der skal ikke meget til at man en dag sidder med lort ned af benet";
            _string.Index(input);
            _string.Contains(input);
            _string.Lenghts(input);
            _string.CharIndex(input);
            _string.DoubleSplit();
            Console.ReadLine();
            Console.Clear();

            _Int _int = new();
            _int.TypeCasting(15);
            _int.IntParse();

        }

        internal static void Namespace_Process(string[] args)
        {
            _Process _process = new();
            _process.Method(args);

        }

        internal static void Namespace_Scheduling()
        {
            PCB pcb = new("Hacking", 1);
            PCB.Retrieve(pcb);

            Console.WriteLine(pcb.ToString());
            Console.ReadLine();
        }

        internal static void Namespace_Stream()
        {
            Read read = new();
            read.ReadTXT();
            read.ReadCSV();
            read.ReadXLSX();

            Write write = new();
            write.WriteTXT();
            write.WriteCSV();
            write.WriteXLSX();
        }

        internal static void Namespace_Threading()
        {
            _Threading _threading = new();
            _threading.Method();
        }

        internal static void Namespace_Async()
        {

        }

        internal static void Namespace_Socket()
        {

        }
    }
}
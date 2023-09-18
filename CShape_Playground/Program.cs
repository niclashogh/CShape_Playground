using CShape_Playground.Array;
using CShape_Playground.Enumeration;
using CShape_Playground.Loop;

namespace CShape_Playground
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Namespace_Array();
            //Namespace_Delegate();
            //Namespace_ObserverPattern();
            //Namespace_Enum();
            //Namespace_Loop(); //Not Complete
            
        }

        internal static void Namespace_Array()
        {
            _ArrayList _arrayList = new();
            _Dictionary _dictionary = new();
            _List _list = new();
            _ListDictonary _listDictonary = new();
            FindOccaurance _findOccaurance = new();
            Array.Math _math = new();
            Sort _sort = new();

            _arrayList.Main();
            Console.ReadLine();
            Console.Clear();

            _dictionary.Main();
            Console.ReadLine();
            Console.Clear();

            _list.Main();
            Console.ReadLine();
            Console.Clear();

            _listDictonary.Main();
            Console.ReadLine();
            Console.Clear();

            _findOccaurance.Main();
            Console.ReadLine();
            Console.Clear();

            _math.Avg();
            Console.ReadLine();
            Console.Clear();

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
            _Enum.Method();
        }

        internal static void Namespace_Loop()
        {
            _DoWhile.Method();
            Console.ReadLine();
            Console.Clear();

            _Switch.Method();
            Console.ReadLine();
            Console.Clear();

            _While.Method();
            Console.ReadLine();
            Console.Clear();
        }
    }
}
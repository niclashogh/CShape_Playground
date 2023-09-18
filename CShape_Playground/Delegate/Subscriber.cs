
namespace CShape_Playground.Delegate
{
    public class Subscriber
    {
        public string Name { get; }

        public Subscriber(string name)
        {
            Name = name;
        }

        public void BroadCastItem(object item)
        {
            Console.WriteLine($"Subscriber '{Name}' recived '{item}'");
        }
    }
}

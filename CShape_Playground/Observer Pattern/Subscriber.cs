using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace CShape_Playground.Observer_Pattern
{
    public class Subscriber : SubscriberMetaData
    {
        public object BroadCastItem { get; set; }

        private Publicher Publicher;

        public Subscriber(Publicher publicher, string name) : base(name)
        {
            Publicher = publicher;
        }

        public override void Update()
        {
            BroadCastItem = Publicher.BroadCastItem;
            Console.WriteLine($"Subscriber '{Name}' reviced '{BroadCastItem}' from '{Publicher.Name}'");
        }
    }

    public class SubscriberMetaData : Observer
    {
        public string Name { get; }

        public SubscriberMetaData(string name)
        {
            Name = name;
        }

        public override void Update()
        { }
    }
}

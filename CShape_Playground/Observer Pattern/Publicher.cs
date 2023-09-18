using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShape_Playground.Observer_Pattern
{
    public class Publicher : PublicherMetaData
    {
        private object broadCastItem;
        public object BroadCastItem
        {
            get { return broadCastItem; }
            set { broadCastItem = value; Notify(); }
        }

        public Publicher(string name) : base(name)
        { }
    }

    public class PublicherMetaData : ObserverList
    {
        public string Name { get; }

        public PublicherMetaData(string name)
        {
            Name = name;
        }
    }
}

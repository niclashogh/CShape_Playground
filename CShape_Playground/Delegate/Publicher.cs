
namespace CShape_Playground.Delegate
{
    public delegate void NewsHandler(object item);

    public class Publicher
    {
        public NewsHandler BroadCast;

        #region Variables & Properties
        public string Name { get; }
        private object broadCastItem;

        public object BroadCastItem
        {
            get { return broadCastItem; }
            set
            {
                if (broadCastItem != value && BroadCast != null)
                {
                    broadCastItem = value;
                    BroadCast(BroadCastItem);
                }
            }
        }
        #endregion

        public Publicher(string name)
        {
            this.Name = name;
        }
    }
}

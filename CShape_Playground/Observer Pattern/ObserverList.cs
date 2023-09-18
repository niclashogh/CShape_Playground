
namespace CShape_Playground.Observer_Pattern
{
    public abstract class ObserverList
    {
        //New Observer
        private List<Observer> observers = new List<Observer>();

        //Add, Remove & Notify observers
        public void Attach(Observer o)
        {
            observers.Add(o);
        }

        public void Detach(Observer o)
        {
            observers.Remove(o);
        }

        public void Notify()
        {
            foreach (Observer o in observers)
            {
                o.Update();
            }
        }
    }

    public abstract class Observer
    {
        public abstract void Update();
    }
}

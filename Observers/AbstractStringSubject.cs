using System.Collections.Generic;

namespace Observers
{
    public abstract class AbstractStringSubject : ISubject<AbstractStringSubject>
    {
        private ICollection<IObserver<AbstractStringSubject>> obsLst;

        private string item;

        protected AbstractStringSubject()
        {
            obsLst = new List<IObserver<AbstractStringSubject>>();
        }

        public void RegisterObserver(IObserver<AbstractStringSubject> obs)
        {
            obsLst.Add(obs);
        }
        public void RemoveObserver(IObserver<AbstractStringSubject> obs)
        {
            obsLst.Remove(obs);
        }

        public string Item 
        { 
            get => item;
            
            protected set
            {
                item = value;

                foreach(IObserver<AbstractStringSubject> obs in obsLst)
                {
                    obs.Update(this);
                }
            }
        }
    }
}
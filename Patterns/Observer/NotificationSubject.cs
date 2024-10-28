using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syntaxApp.Patterns.Observer
{
    public class NotificationSubject : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        private string _latest_msg = "";

        public void setNewMsg(string new_msg)
        {
            _latest_msg = new_msg;
            NotifyAll();
        }
        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void ClearObservers()
        {
            _observers.Clear();
        }

        public void NotifyAll()
        {
            foreach (var obs in _observers)
            {
                obs.Update(_latest_msg);
            }
        }
    }
}

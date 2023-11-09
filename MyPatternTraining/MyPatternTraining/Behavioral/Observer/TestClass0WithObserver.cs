using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPatternTraining.Behavioral.Observer
{
    internal interface ITestClassWithObserver
    {
        public List<IObserver> Observers { get; set; }

        void AddObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers(string message);
    }

    internal class TestClass0WithObserver : ITestClassWithObserver
    {
        public List<IObserver> Observers { get; set; }

        public TestClass0WithObserver(List<IObserver> observers)
        {
            Observers = observers;
        }

        public void AddObserver(IObserver o)
        {
            Observers.Add(o);
        }

        public void NotifyObservers(string message)
        {
            Observers.ForEach(z => z.LogInformation(message));
        }

        public void RemoveObserver(IObserver o)
        {
            Observers.Remove(o);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPatternTraining.Behavioral.Observer
{
    /// <summary>
    /// Наблюдатель.
    /// </summary>
    internal interface IObserver
    {
        void LogInformation(string message);
    }

    internal class ConcreteObserver1 : IObserver
    {
        public void LogInformation(string message)
        {
            Console.WriteLine(nameof(ConcreteObserver1) + " log action: " + message);
        }
    }

    internal class ConcreteObserver2 : IObserver
    {
        public void LogInformation(string message)
        {
            Console.WriteLine(nameof(ConcreteObserver2) + " log action: " + message);
        }
    }
}

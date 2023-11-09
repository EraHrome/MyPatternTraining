using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPatternTraining.Behavioral
{
    internal interface IStrategy
    {
        internal void Method();
    }

    public class ConcreteStrategy1 : IStrategy
    {
        public void Method()
        {
            Console.WriteLine(nameof(ConcreteStrategy1));
        }
    }

    public class ConcreteStrategy2 : IStrategy
    {
        public void Method()
        {
            Console.WriteLine(nameof(ConcreteStrategy2));
        }
    }
}

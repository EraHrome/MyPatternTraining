using MyPatternTraining.TestClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPatternTraining.Creational.AbstractFactory
{
    internal abstract class AbstractFactory
    {
        internal abstract TestClass0 CreateTestClass0();
        internal abstract TestClass1 CreateTestClass1();
    }

    internal class AbstractFactory0 : AbstractFactory
    {
        internal override TestClass0 CreateTestClass0()
        {
            return new TestClass0();
        }

        internal override TestClass1 CreateTestClass1()
        {
            return new TestClass1("from " + nameof(AbstractFactory0));
        }
    }

    internal class AbstractFactory1 : AbstractFactory
    {
        internal override TestClass0 CreateTestClass0()
        {
            return new TestClass0();
        }

        internal override TestClass1 CreateTestClass1()
        {
            return new TestClass1("from " + nameof(AbstractFactory1));
        }
    }
}

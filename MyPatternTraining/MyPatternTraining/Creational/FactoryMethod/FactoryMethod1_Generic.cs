using MyPatternTraining.TestClasses;

namespace MyPatternTraining.Creational.FactoryMethod
{
    internal abstract class ClassWithFactoryMethodGeneric<T>
    {
        internal abstract T Create();
    }

    internal class ConcreteClassWithFactoryMethod0 : ClassWithFactoryMethodGeneric<TestClass0>
    {
        internal override TestClass0 Create()
        {
            return new TestClass0();
        }
    }

    internal class ConcreteClassWithFactoryMethod1 : ClassWithFactoryMethodGeneric<TestClass1>
    {
        internal override TestClass1 Create()
        {
            return new TestClass1("Create TestClass1 from ConcreteClassWithFactoryMethod1");
        }
    }
}

using MyPatternTraining.TestClasses;

namespace MyPatternTraining.Creational.Singleton
{
    internal abstract class ClassWithFactoryMethod<T>
    {
        internal abstract T Create();
    }

    internal class ConcreteClassWithFactoryMethod0 : ClassWithFactoryMethod<TestClass0>
    {
        internal override TestClass0 Create()
        {
            return new TestClass0();
        }
    }

    internal class ConcreteClassWithFactoryMethod1 : ClassWithFactoryMethod<TestClass1>
    {
        internal override TestClass1 Create()
        {
            return new TestClass1("Create TestClass1 from ConcreteClassWithFactoryMethod1");
        }
    }
}

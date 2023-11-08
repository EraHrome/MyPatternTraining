using MyPatternTraining.TestClasses;

namespace MyPatternTraining.Creational.FactoryMethod
{
    internal abstract class StandartFactoryMethod
    {
        internal abstract TestClass01Parent Create();
    }

    internal class StandartFactoryMethod1 : StandartFactoryMethod
    {
        internal override TestClass01Parent Create()
        {
            return new TestClass0();
        }
    }

    internal class StandartFactoryMethod2 : StandartFactoryMethod
    {
        internal override TestClass01Parent Create()
        {
            return new TestClass1("from StandartFactoryMethod2");
        }
    }
}

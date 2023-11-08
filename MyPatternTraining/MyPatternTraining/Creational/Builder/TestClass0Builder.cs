namespace MyPatternTraining.Creational.Builder
{
    internal class TestClass0Builder : Builder<TestClass0ForBuilder>
    {
        public override TestClass0ForBuilder Model { get; init; }

        public TestClass0Builder()
        {
            Model = new TestClass0ForBuilder();
        }

        public override Builder<TestClass0ForBuilder> AddProp1(int prop1)
        {
            Model.Prop1 = prop1;
            return this;
        }

        public override Builder<TestClass0ForBuilder> AddProp2(int prop2)
        {
            Model.Prop2 = prop2;
            return this;
        }

        public override Builder<TestClass0ForBuilder> AddProp3(int prop3)
        {
            Model.Prop3 = prop3;
            return this;
        }

        public override TestClass0ForBuilder Build()
        {
            return Model;
        }
    }
}

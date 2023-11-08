namespace MyPatternTraining.TestClasses
{
    internal class TestClass0 : TestClass01Parent
    {
        public int TestField { get; set; } = 90;

        public TestClass0()
        {

        }

        internal override void TestMethod()
        {
            Console.WriteLine("TestMethod from TestClass0");
        }
    }
}

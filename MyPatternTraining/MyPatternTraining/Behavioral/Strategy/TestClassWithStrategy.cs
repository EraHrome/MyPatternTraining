namespace MyPatternTraining.Behavioral.Strategy
{
    internal class TestClassWithStrategy
    {
        public IStrategy Strategy { get; set; }

        public TestClassWithStrategy(IStrategy strategy)
        {
            Strategy = strategy;
        }

        public void MethodWithStrategy()
        {
            Console.WriteLine(nameof(TestClassWithStrategy));
            Strategy.Method();
        }
    }
}

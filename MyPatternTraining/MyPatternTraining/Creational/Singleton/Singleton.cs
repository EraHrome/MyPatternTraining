namespace MyPatternTraining.Creational.Singleton
{
    internal class Singleton<T> where T : class, new()
    {
        private T @object;

        public T Instance { get => GetInstance(); }

        private T GetInstance()
        {
            if (@object is null)
            {
                @object = new T();
            }
            return @object;
        }
    }
}

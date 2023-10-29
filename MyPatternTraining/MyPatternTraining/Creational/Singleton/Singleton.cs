namespace MyPatternTraining.Creational.Singleton
{
    internal class Singleton<T> where T : class, new()
    {
        private static object syncRoot = new Object();
        private T @object;

        public T Instance { get => GetInstance(); }

        private T GetInstance()
        {
            if (@object is null)
            {
                lock (syncRoot)
                {
                    @object = new T();
                }
            }
            return @object;
        }
    }
}

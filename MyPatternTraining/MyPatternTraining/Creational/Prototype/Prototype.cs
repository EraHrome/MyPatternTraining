using System.Text.Json;

namespace MyPatternTraining.Creational.Prototype
{
    public abstract class Prototype<T>
    {
        public abstract T Clone();
    }
}

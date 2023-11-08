using MyPatternTraining.Creational.Builder.Interfaces;

namespace MyPatternTraining.Creational.Builder
{
    public abstract class Builder<T> where T : IProp1, IProp2, IProp3
    {
        public abstract T Model { get; init; }

        public abstract Builder<T> AddProp1(int prop1);
        public abstract Builder<T> AddProp2(int prop2);
        public abstract Builder<T> AddProp3(int prop3);

        public abstract T Build();
    }
}

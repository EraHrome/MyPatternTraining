using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MyPatternTraining.Creational.Prototype
{
    internal class TestClassForPrototype0 : Prototype<TestClassForPrototype0>
    {
        public int Prop1 { get; set; }
        public int Prop2 { get; set; }
        public int Prop3 { get; set; }

        public override TestClassForPrototype0 Clone()
        {
            var result = JsonSerializer.Deserialize<TestClassForPrototype0>(JsonSerializer.Serialize(this));
            return result;
        }
    }
}

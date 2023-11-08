using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPatternTraining.TestClasses
{
    internal class TestClass1 : TestClass01Parent
    {
        public string Text { get; set; }

        public TestClass1(string text)
        {
            Text = text;
        }
    }
}

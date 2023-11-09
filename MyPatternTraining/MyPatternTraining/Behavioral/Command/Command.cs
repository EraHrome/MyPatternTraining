using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPatternTraining.Behavioral.Command
{
    public class Command
    {
        public string Operator { get; set; }
        public uint Number { get; set; }

        public Command(string @operator, uint number)
        {
            Operator = @operator;
            Number = number;
        }
    }
}

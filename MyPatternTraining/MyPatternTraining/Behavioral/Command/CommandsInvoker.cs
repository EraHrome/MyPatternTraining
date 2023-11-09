using Commanda = MyPatternTraining.Behavioral.Command.Command;

namespace MyPatternTraining.Behavioral.Observer
{
    internal class CommandsInvoker
    {
        private List<Commanda> Commands { get; init; } = new List<Commanda>();

        public CommandsInvoker AddCommand(Commanda commanda)
        {
            Commands.Add(commanda);
            return this;
        }

        public int Invoke()
        {
            var result = 0;
            foreach (var command in Commands)
            {
                var @operator = command.Operator;
                var number = Convert.ToInt32(command.Number);
                if (@operator == "+")
                {
                    result += number;
                }
                else if (@operator == "-")
                {
                    result -= number;
                }
                else if (@operator == "*")
                {
                    result *= number;
                }
                else if (@operator == "/")
                {
                    result /= number;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            return result;
        }
    }
}

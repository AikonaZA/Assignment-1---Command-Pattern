using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Command_Pattern
{
    //Invoker Class, User that makes the choice
    class Invoker
    {
        // Initializers
        private Receiver _receiver = new Receiver();
        private List<Command> _commands = new List<Command>();
        private int _current = 0;

        public void Redo(int levels)
        {
            Console.WriteLine("\n---- Redo {0} levels ", levels);
            // Perform redo operations
            for (int i = 0; i < levels; i++)
            {
                if (_current < _commands.Count - 1)
                {
                    Command command = _commands[_current++];
                    command.Execute();
                }
            }
        }

        public void Undo(int levels)
        {
            Console.WriteLine("\n---- Undo {0} levels ", levels);
            // Perform undo operations
            for (int i = 0; i < levels; i++)
            {
                if (_current > 0)
                {
                    Command command = _commands[--_current] as Command;
                    command.UnExecute();
                }
            }
        }
        //Kitchen = choiceK, Ingredient choiceI
        public void Compute(string choiceK, string choiceI)
        {
            // Create command operation and execute it
            Command command = new ConcreteCommand(_receiver, choiceK, choiceI);
            command.Execute();

            // Add command to undo list
            _commands.Add(command);
            _current++;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Command_Pattern
{
    class ConcreteCommand : Command
    {
        private string _choiceK, _choiceI;
        private Receiver _receiver;

        // Constructor
        public ConcreteCommand(Receiver receiver, string choiceK, string choiceI)
        {
            this._receiver = receiver;
            this._choiceK = choiceK;
            this._choiceI = choiceI;
        }

        // Gets Kitchen choice
        public string ChoiceK
        {
            set { _choiceK = value; }
        }
        // Gets Ingredient Choice
        public string ChoiceI
        {
            set { _choiceI = value; }
        }

        // Execute new command
        public override void Execute()
        {
            _receiver.Operation(_choiceK, _choiceI);
        }

        // Unexecute last command
        public override void UnExecute()
        {
            _receiver.Operation(Undo(_choiceK, _choiceI), _choiceI);
        }

        // Returns opposite operator for given operator
        private string Undo(string choiceK, string choiceI)
        {
            string _undo = "No Choice";
            switch (choiceK)
            {
                case "US": return _choiceK = _undo;
                case "us": return _choiceK = _undo;
                case "SA": return _choiceK = _undo;
                case "sa": return _choiceK = _undo;
            }
            switch (choiceI)
            {
                case "Taco": return _choiceI = _undo;
                case "taco": return _choiceI = _undo;
                case "Burrito": return _choiceI = _undo;
                case "burrito": return _choiceI = _undo;
                default:
                    throw new ArgumentException("choice");
            }
        }
    }
}

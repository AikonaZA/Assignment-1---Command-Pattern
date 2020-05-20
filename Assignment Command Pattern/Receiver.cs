using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Command_Pattern
{
    //Receiver Class, Choice mechanic
    class Receiver
    {
        private string _currentK = "Choose";
        private string _currentI = "Choose";

        public void Operation(string choiceK, string choiceI)
        {
            switch (choiceK)
            {
                case "US": _currentK = "US Kitchen"; break;
                case "us": _currentK = "US Kitchen"; break;
                case "SA": _currentK = "SA Kitchen"; break;
                case "sa": _currentK = "SA Kitchen"; break;
            }
            switch (choiceI)
            {
                case "Taco": _currentI = "Taco"; break;
                case "taco": _currentI = "Taco"; break;
                case "Burrito": _currentI = "Burrito"; break;
                case "burrito": _currentI = "Burrito"; break;
            }

            //This is where the final changes are set, 
            //Console.WriteLine is used only as an example
            Console.WriteLine(
                "Current Choice = {0} & {1}", _currentK, _currentI);
        }
    }
}

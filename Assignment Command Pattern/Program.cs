using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Command_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create user and let her compute
            Invoker invoker = new Invoker();

            // User chooses the stuff, after 2 questions this executes
            invoker.Compute("US", "Taco");
            invoker.Compute("SA", "Taco");
            invoker.Compute("US", "taco");
            invoker.Compute("US", "Burrito");
            invoker.Compute("sa", "Taco");

            // Undo 4 commands
            invoker.Undo(4);

            // Redo 3 commands
            invoker.Redo(3);

            // Wait for user
            Console.ReadKey();
        }
    }
}

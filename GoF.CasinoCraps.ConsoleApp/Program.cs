using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.CasinoCraps.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("casino craps started - type 'exit' to exit.");
            Console.WriteLine();
            string line;
            while ((line = Console.ReadLine().ToLower()) != "exit")
            {
                // Do stuff.
            }
        }
    }
}

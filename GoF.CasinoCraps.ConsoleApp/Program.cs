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
            ConsoleGame game = new ConsoleGame(new Game());

            Console.WriteLine("casino craps started - type 'exit' to exit.");
            Console.WriteLine();
            string line;
            while ((line = Console.ReadLine().ToLower()) != "exit")
            {
                string output = game.Execute(line);
                Console.WriteLine("--> {0}", output);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace GoF.CasinoCraps
{
    public class Game
    {
        private int rollNumber;

        public Game()
        {
        }

        public string Execute(string command)
        {
            Contract.Requires(string.IsNullOrWhiteSpace(command) == false);

            string[] items = command.Split(' ');

            if (items[0] == "roll")
            {
                rollNumber++;

                Roll roll;
                if (items.Count() == 3)
                {
                    roll = new Roll(Convert.ToInt32(items[1]), Convert.ToInt32(items[2]));
                }
                else
                {
                    roll = new Roll();
                }
                 
                return string.Format("roll #{0} - [{1}] [{2}] - ({3})", rollNumber, roll.FirstDie, roll.SecondDie, roll.DiceTotal);
            }

            return "unknown command";
        }
    }
}

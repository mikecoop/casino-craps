namespace GoF.CasinoCraps
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Linq;

    /// <summary>
    /// Represents a game of casino craps.
    /// </summary>
    public class Game
    {
        /// <summary>
        /// The current roll number in the game starting from one.
        /// </summary>
        private int rollNumber;

        /// <summary>
        /// Initializes a new instance of the <see cref="Game"/> class.
        /// </summary>
        public Game()
        {
        }

        /// <summary>
        /// Executes the given command.
        /// </summary>
        /// <param name="command">The command to execute.</param>
        /// <returns>A message with the results of the command.</returns>
        public string Execute(string command)
        {
            Contract.Requires(string.IsNullOrWhiteSpace(command) == false);

            if (command == "new-game")
            {
                rollNumber = 0;
                return "new game started...";
            }

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

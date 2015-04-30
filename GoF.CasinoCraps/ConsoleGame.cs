namespace GoF.CasinoCraps
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Wrapper for a craps game played through a console.
    /// </summary>
    public class ConsoleGame
    {
        private readonly Game game;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsoleGame"/> class.
        /// </summary>
        /// <param name="game">The craps game object.</param>
        public ConsoleGame(Game game)
        {
            this.game = game;
        }

        /// <summary>
        /// Gets the current round number for the game.
        /// </summary>
        public int RoundNumber
        {
            get
            {
                return game.RoundNumber;
            }
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
                game.Restart();
                return "new game started...";
            }

            string[] items = command.Split(' ');

            if (items[0] == "roll")
            {
                int currentRollNumber = game.RollNumber;
                Roll roll;
                if (items.Count() == 3)
                {
                    roll = game.RollDice(Convert.ToInt32(items[1]), Convert.ToInt32(items[2]));
                }
                else
                {
                    roll = game.RollDice();
                }

                return string.Format("roll #{0} - [{1}] [{2}] - ({3})", currentRollNumber, roll.FirstDie, roll.SecondDie, roll.DiceTotal);
            }

            return "unknown command";
        }
    }
}

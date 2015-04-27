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
        private readonly Round round;

        /// <summary>
        /// Initializes a new instance of the <see cref="Game"/> class.
        /// </summary>
        public Game()
        {
            RollNumber = 1;
            RoundNumber = 1;
            round = new Round();
            round.RoundEnded += RoundEnded;
        }

        /// <summary>
        /// Gets the current roll number for the game.
        /// </summary>
        public int RollNumber { get; private set; }

        /// <summary>
        /// Gets the current round number for the game.
        /// </summary>
        public int RoundNumber { get; private set; }

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
                RollNumber = 1;
                return "new game started...";
            }

            string[] items = command.Split(' ');

            if (items[0] == "roll")
            {
                int currentRollNumber = RollNumber;
                RollNumber++;
                Roll roll = GetRoll(items);
                round.SetNextRoll(roll);

                return string.Format("roll #{0} - [{1}] [{2}] - ({3})", currentRollNumber, roll.FirstDie, roll.SecondDie, roll.DiceTotal);
            }

            return "unknown command";
        }

        private Roll GetRoll(string[] items)
        {
            Roll roll;
            if (items.Count() == 3)
            {
                roll = new Roll(Convert.ToInt32(items[1]), Convert.ToInt32(items[2]));
            }
            else
            {
                roll = new Roll();
            }

            return roll;
        }

        private void RoundEnded(object sender, RoundEndedEventArgs e)
        {
            round.Reset();
            RoundNumber++;
        }
    }
}

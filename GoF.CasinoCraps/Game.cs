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
        /// Restarts the game.
        /// </summary>
        public void Restart()
        {
            RollNumber = 1;
            RoundNumber = 1;
            round.Reset();
        }

        /// <summary>
        /// Rolls the dice for the current game.
        /// </summary>
        /// <returns>The new roll.</returns>
        public Roll RollDice()
        {
            return SetNextRoll(new Roll());
        }

        /// <summary>
        /// Rolls the dice and sets the to the given values.
        /// </summary>
        /// <param name="firstDie">The first die value.</param>
        /// <param name="secondDie">The second die value.</param>
        /// <returns>The new roll.</returns>
        public Roll RollDice(int firstDie, int secondDie)
        {
            Contract.Requires(1 <= firstDie && firstDie <= 6);
            Contract.Requires(1 <= secondDie && secondDie <= 6);

            return SetNextRoll(new Roll(firstDie, secondDie));
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
                Restart();
                return "new game started...";
            }

            string[] items = command.Split(' ');

            if (items[0] == "roll")
            {
                int currentRollNumber = RollNumber;
                Roll roll;
                if (items.Count() == 3)
                {
                    roll = RollDice(Convert.ToInt32(items[1]), Convert.ToInt32(items[2]));
                }
                else
                {
                    roll = RollDice();
                }

                return string.Format("roll #{0} - [{1}] [{2}] - ({3})", currentRollNumber, roll.FirstDie, roll.SecondDie, roll.DiceTotal);
            }

            return "unknown command";
        }

        private Roll SetNextRoll(Roll roll)
        {
            Contract.Requires(roll != null);

            RollNumber++;
            round.SetNextRoll(roll);
            return roll;
        }

        private void RoundEnded(object sender, RoundEndedEventArgs e)
        {
            round.Reset();
            RoundNumber++;
        }
    }
}

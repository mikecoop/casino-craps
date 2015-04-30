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
        /// Rolls the dice and sets them to the given values.
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

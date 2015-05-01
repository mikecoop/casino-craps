namespace GoF.CasinoCraps
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public interface IGame
    {
        /// <summary>
        /// Gets the current roll number for the game.
        /// </summary>
        int RollNumber { get; }
        /// <summary>
        /// Gets the current round number for the game.
        /// </summary>
        int RoundNumber { get; }
        IEnumerable<Bet> ActiveBets { get; }

        IEnumerable<Bet> CompletedBets { get; }

        /// <summary>
        /// Restarts the game.
        /// </summary>
        void Restart();

        /// <summary>
        /// Rolls the dice for the current game.
        /// </summary>
        /// <returns>The new roll.</returns>
        Roll RollDice();

        /// <summary>
        /// Rolls the dice and sets them to the given values.
        /// </summary>
        /// <param name="firstDie">The first die value.</param>
        /// <param name="secondDie">The second die value.</param>
        /// <returns>The new roll.</returns>
        Roll RollDice(int firstDie, int secondDie);

        /// <summary>
        /// Places a bet for the current game.
        /// </summary>
        /// <param name="bet">The bet to place.</param>
        void PlaceBet(Bet bet);
    }
}


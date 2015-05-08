namespace GoF.CasinoCraps
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a snake-eyes bet in craps.
    /// </summary>
    public class SnakeEyesBet : Bet
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SnakeEyesBet"/> class.
        /// </summary>
        /// <param name="amount">The amount of the bet.</param>
        public SnakeEyesBet(int amount)
            : base(amount)
        {
        }

        /// <summary>
        /// Gets the payout odds of the bet.
        /// </summary>
        public override int Odds
        {
            get
            {
                return 30;
            }
        }

        /// <summary>
        /// Notifies the bet that the dice have been rolled.
        /// </summary>
        /// <param name="roll">The roll.</param>
        public override void DiceRolled(Roll roll)
        {
            if (roll.Name == RollName.SnakeEyes)
            {
                Status = BetStatus.Won;
            }
            else
            {
                Status = BetStatus.Lost;
            }
        }

        /// <summary>
        /// Notifies the bet that the round has ended.
        /// </summary>
        /// <param name="args">The RoundEndedEventArgs arguments.</param>
        public override void RoundEnded(RoundEndedEventArgs args)
        {
            // Do nothing.
        }
    }
}

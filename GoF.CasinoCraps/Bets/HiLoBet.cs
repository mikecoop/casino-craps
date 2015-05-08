namespace GoF.CasinoCraps
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a hi-lo bet in craps.
    /// </summary>
    public class HiLoBet : Bet
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HiLoBet"/> class.
        /// </summary>
        /// <param name="amount">The amount of the bet.</param>
        public HiLoBet(int amount)
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
                return 15;
            }
        }

        /// <summary>
        /// Notifies the bet that the dice have been rolled.
        /// </summary>
        /// <param name="roll">The roll.</param>
        public override void DiceRolled(Roll roll)
        {
            if (roll.Name == RollName.SnakeEyes || roll.Name == RollName.Boxcars)
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

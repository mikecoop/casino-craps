namespace GoF.CasinoCraps
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a big eight bet in craps.
    /// </summary>
    public class BigEightBet : Bet
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BigEightBet"/> class.
        /// </summary>
        /// <param name="amount">The amount of the bet.</param>
        public BigEightBet(int amount)
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
                return 1;
            }
        }

        /// <summary>
        /// Notifies the bet that the dice have been rolled.
        /// </summary>
        /// <param name="roll">The roll.</param>
        public override void DiceRolled(Roll roll)
        {
            if (roll.DiceTotal == 7)
            {
                Status = BetStatus.Lost;
            }
            else if (roll.DiceTotal == 8)
            {
                Status = BetStatus.Won;
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

namespace GoF.CasinoCraps
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a yo bet in craps.
    /// (Requirement 2.6.3)
    /// </summary>
    public class YoBet : Bet
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="YoBet"/> class.
        /// </summary>
        /// <param name="amount">The amount of the bet.</param>
        public YoBet(int amount)
            : base(amount)
        {
        }

        /// <summary>
        /// Gets the name of the bet.
        /// </summary>
        public override string Name
        {
            get
            {
                return "Yo";
            }
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
            if (roll.Name == RollName.Yo)
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

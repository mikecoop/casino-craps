namespace GoF.CasinoCraps
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a horn bet in craps.
    /// </summary>
    public class TheHornBet : Bet
    {
        private int odds;

        /// <summary>
        /// Initializes a new instance of the <see cref="TheHornBet"/> class.
        /// </summary>
        /// <param name="amount">The amount of the bet.</param>
        public TheHornBet(int amount)
            : base(Convert.ToInt32(amount / 4))
        {
            if (amount % 4 != 0)
            {
                throw new BetAmountException("Amount must be divisible by 4");
            }

            odds = 0;
        }

        /// <summary>
        /// Gets the payout odds of the bet.
        /// </summary>
        public override int Odds
        {
            get
            {
                return odds;
            }
        }

        /// <summary>
        /// Notifies the bet that the dice have been rolled.
        /// </summary>
        /// <param name="roll">The roll.</param>
        public override void DiceRolled(Roll roll)
        {
            if (roll.DiceTotal == 3 || roll.DiceTotal == 11)
            {
                odds = 12;
                Status = BetStatus.Won;
            }
            else if (roll.DiceTotal == 2 || roll.DiceTotal == 12)
            {
                odds = 27;
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

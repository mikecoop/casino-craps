namespace GoF.CasinoCraps
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a whirl bet in craps.
    /// </summary>
    public class WhirlBet : Bet
    {
        private int odds;

        /// <summary>
        /// Initializes a new instance of the <see cref="WhirlBet"/> class.
        /// </summary>
        /// <param name="amount">The amount of the bet.</param>
        public WhirlBet(int amount)
            : base(Convert.ToInt32(amount / 5))
        {
            if (amount % 5 != 0)
            {
                throw new BetAmountException("Amount must be divisible by 5");
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
                odds = 11;
                Status = BetStatus.Won;
            }
            else if (roll.DiceTotal == 2 || roll.DiceTotal == 12)
            {
                odds = 26;
                Status = BetStatus.Won;
            }
            else if (roll.DiceTotal == 7)
            {
                odds = 0;
                Status = BetStatus.Push;
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
            // Do nothing
        }
    }
}

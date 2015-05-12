namespace GoF.CasinoCraps
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a don't pass bet.
    /// (Requirement 2.3.0)
    /// </summary>
    public class DontPassBet : Bet
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DontPassBet"/> class.
        /// </summary>
        /// <param name="amount">The amount of the bet.</param>
        public DontPassBet(int amount)
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
                return "Don't Pass";
            }
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
            // Do nothing.
        }

        /// <summary>
        /// Notifies the bet that the round has ended.
        /// (Requirement 4.2.2)
        /// (Requirement 4.3.2)
        /// </summary>
        /// <param name="args">The RoundEndedEventArgs arguments.</param>
        public override void RoundEnded(RoundEndedEventArgs args)
        {
            switch (args.Result)
            {
                case RoundResult.Craps:
                    if (args.Roll.Name == RollName.Boxcars)
                    {
                        Status = BetStatus.Push;
                    }
                    else
                    {
                        Status = BetStatus.Won;
                    }

                    break;
                case RoundResult.Natural:
                    Status = BetStatus.Lost;
                    break;
                case RoundResult.PointHit:
                    Status = BetStatus.Lost;
                    break;
                case RoundResult.SevenOut:
                    Status = BetStatus.Won;
                    break;
                default:
                    break;
            }
        }
    }
}

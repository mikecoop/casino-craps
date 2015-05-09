namespace GoF.CasinoCraps
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a come bet in craps.
    /// (Requirement 3.4)
    /// </summary>
    public class ComeBet : Bet
    {
        private readonly Round round;

        /// <summary>
        /// Initializes a new instance of the <see cref="ComeBet"/> class.
        /// </summary>
        /// <param name="amount">The amount of the bet.</param>
        public ComeBet(int amount)
            : base(amount)
        {
            round = new Round();
            round.RoundEnded += PrivateRoundEnded;
        }

        /// <summary>
        /// Gets the payout odds of the bet.
        /// </summary>
        public override int Odds
        {
            get { return 1; }
        }

        /// <summary>
        /// Notifies the bet that the dice have been rolled.
        /// </summary>
        /// <param name="roll">The roll.</param>
        public override void DiceRolled(Roll roll)
        {
            round.SetNextRoll(roll);
        }

        /// <summary>
        /// Notifies the bet that the round has ended.
        /// </summary>
        /// <param name="args">The RoundEndedEventArgs arguments.</param>
        public override void RoundEnded(RoundEndedEventArgs args)
        {
            // Do nothing.
        }

        //(Requirement 5.2.0)
        //(Requirement 5.5.0)
        private void PrivateRoundEnded(object sender, RoundEndedEventArgs e)
        {
            switch (e.Result)
            {
                case RoundResult.Craps:
                    Status = BetStatus.Lost;
                    break;
                case RoundResult.Natural:
                    Status = BetStatus.Won;
                    break;
                case RoundResult.PointHit:
                    Status = BetStatus.Won;
                    break;
                case RoundResult.SevenOut:
                    Status = BetStatus.Lost;
                    break;
                default:
                    break;
            }
        }
    }
}

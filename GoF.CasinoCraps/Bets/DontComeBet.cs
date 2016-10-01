﻿namespace GoF.CasinoCraps
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a don't come bet in craps.
    /// (Requirement 2.5.0)
    /// (Requirement 2.3.1)
    /// </summary>
    public class DontComeBet : Bet
    {
        private readonly Round round;

        /// <summary>
        /// Initializes a new instance of the <see cref="DontComeBet"/> class.
        /// </summary>
        /// <param name="amount">The amount of the bet.</param>
        public DontComeBet(int amount)
            : base(amount)
        {
            round = new Round();
            round.RoundEnded += PrivateRoundEnded;
        }

        /// <summary>
        /// Gets the name of the bet.
        /// </summary>
        public override string Name
        {
            get
            {
                return "Don't Come";
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

        // (Requirement 3.3.0)
        // (Requirement 3.4.0)
        private void PrivateRoundEnded(object sender, RoundEndedEventArgs e)
        {
            switch (e.Result)
            {
                case RoundResult.Craps:
                    if (e.Roll.Name == RollName.Boxcars)
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

﻿namespace GoF.CasinoCraps
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a pass line bet.
    /// (Requirement 2.2.0)
    /// (Requirement 2.2.1)
    /// </summary>
    public class PassLineBet : Bet
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PassLineBet"/> class.
        /// </summary>
        /// <param name="amount">The amount of the bet.</param>
        public PassLineBet(int amount)
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
                return "Pass Line";
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
        /// (Requirement 4.2.1)
        /// (Requirement 4.3.1)
        /// </summary>
        /// <param name="args">The RoundEndedEventArgs arguments.</param>
        public override void RoundEnded(RoundEndedEventArgs args)
        {
            switch (args.Result)
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

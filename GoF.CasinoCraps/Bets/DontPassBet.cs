using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace GoF.CasinoCraps
{
    /// <summary>
    /// Represents a don't pass bet.
    /// </summary>
    public class DontPassBet : Bet
    {
        public DontPassBet(int amount)
            : base(amount)
        {
        }

        public override int Odds
        {
            get { return 1; }
        }

        public override void DiceRolled(Roll roll)
        {
            // Do nothing.
        }

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

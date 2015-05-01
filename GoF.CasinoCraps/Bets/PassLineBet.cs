using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.CasinoCraps
{
    /// <summary>
    /// Represents a pass line bet.
    /// </summary>
    public class PassLineBet : Bet
    {
        public PassLineBet(int amount)
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

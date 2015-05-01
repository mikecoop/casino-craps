using System;
using System.Collections.Generic;
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
        public void RoundEnded(RoundResult result)
        {
            switch (result)
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

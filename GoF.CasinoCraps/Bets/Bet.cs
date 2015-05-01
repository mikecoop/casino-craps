using System;
using System.Collections.Generic;
using System.Linq;

namespace GoF.CasinoCraps
{
    /// <summary>
    /// Represents a bet in craps.
    /// </summary>
    public abstract class Bet
    {
        public Bet(int amount)
        {
            Status = BetStatus.Active;
            Amount = amount;
        }

        public BetStatus Status { get; protected set; }

        public int Amount { get; protected set; }

        public Decimal PayoutAmount
        {
            get
            {
                if (Status == BetStatus.Won)
                {
                    return Amount + Amount * Odds;
                }
                else if (Status == BetStatus.Push)
                {
                    return Amount;
                }

                return 0;
            }
        }

        public abstract int Odds { get; }

        public abstract void RoundEnded(RoundEndedEventArgs args);
    }
}

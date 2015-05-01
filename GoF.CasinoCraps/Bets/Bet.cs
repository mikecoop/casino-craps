using System;
using System.Collections.Generic;
using System.Linq;

namespace GoF.CasinoCraps
{
    /// <summary>
    /// Represents a bet in craps.
    /// </summary>
    public class Bet
    {
        public Bet()
        {
            Status = BetStatus.Active;
        }

        public BetStatus Status { get; protected set; }
    }
}

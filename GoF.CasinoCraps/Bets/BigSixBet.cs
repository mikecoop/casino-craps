using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.CasinoCraps
{
    public class BigSixBet : Bet
    {
        public BigSixBet(int amount) : base(amount)
        {
        }

        public override int Odds
        {
            get
            {
                return 1;
            }
        }

        public override void DiceRolled(Roll roll)
        {
            if (roll.DiceTotal == 7)
            {
                Status = BetStatus.Lost;
            }
            else if (roll.DiceTotal == 6)
            {
                Status = BetStatus.Won;
            }
        }

        public override void RoundEnded(RoundEndedEventArgs args)
        {
            // Do nothing.
        }
    }
}

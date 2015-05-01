using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.CasinoCraps
{
    public class AnySevenBet : Bet
    {
        public AnySevenBet(int amount)
            : base(amount)
        {
        }

        public override int Odds
        {
            get
            {
                return 4;
            }
        }

        public override void DiceRolled(Roll roll)
        {
            if (roll.DiceTotal == 7)
            {
                Status = BetStatus.Won;
            }
            else
            {
                Status = BetStatus.Lost;
            }
        }

        public override void RoundEnded(RoundEndedEventArgs args)
        {
            // Do nothing.
        }
    }
}

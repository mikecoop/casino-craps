using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.CasinoCraps
{
    public class CAndEBet : Bet
    {
        private int odds;

        public CAndEBet(int amount)
            : base(Convert.ToInt32(amount / 2))
        {
            odds = 0;
        }

        public override int Odds
        {
            get
            {
                return odds;
            }
        }

        public override void DiceRolled(Roll roll)
        {
            if (roll.IsCraps)
            {
                odds = 3;
                Status = BetStatus.Won;
            }
            else if (roll.Name == RollName.Yo)
            {
                odds = 7;
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

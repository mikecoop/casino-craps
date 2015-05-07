using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.CasinoCraps
{
    public class TheHornBet : Bet
    {
        private int odds;

        public TheHornBet(int amount): base(Convert.ToInt32(amount / 4))
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
            if (roll.DiceTotal == 3 || roll.DiceTotal == 11)
            {
                odds = 12;
                Status = BetStatus.Won;
            }
            else if (roll.DiceTotal == 2 || roll.DiceTotal == 12)
            {
                odds = 27;
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

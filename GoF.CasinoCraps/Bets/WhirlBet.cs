using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.CasinoCraps
{
    public class WhirlBet : Bet
    {
        private int odds;

        public WhirlBet(int amount): base(Convert.ToInt32(amount / 5))
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
                odds = 11;
                Status = BetStatus.Won;
            }
            else if (roll.DiceTotal == 2 || roll.DiceTotal == 12)
            {
                odds = 26;
                Status = BetStatus.Won;
            }
            else if (roll.DiceTotal == 7)
            {
                odds = 0;
                Status = BetStatus.Push;
            }
            else
            {
                Status = BetStatus.Lost;
            }
        }

        public override void RoundEnded(RoundEndedEventArgs args)
        {
            // Do nothing
        }
    }
}

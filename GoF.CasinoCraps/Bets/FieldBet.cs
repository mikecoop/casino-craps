using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.CasinoCraps
{
    public class FieldBet : Bet
    {
        private int odds;

        public FieldBet(int amount) : base(amount)
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
            if (roll.DiceTotal == 3 || 
                roll.DiceTotal == 4 ||
                roll.DiceTotal == 9 ||
                roll.DiceTotal == 10 ||
                roll.DiceTotal == 11)
            {
                odds = 1;
                Status = BetStatus.Won;
            }
            else if (roll.DiceTotal == 2)
            {
                odds = 2;
                Status = BetStatus.Won;
            }
            else if (roll.DiceTotal == 12)
            {
                odds = 3;
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

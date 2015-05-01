using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.CasinoCraps
{
    public class SnakeEyesBet : Bet
    {
        public SnakeEyesBet(int amount): base(amount)
        {
        }

        public override int Odds
        {
            get
            {
                return 30;
            }
        }

        public override void DiceRolled(Roll roll)
        {
            if (roll.Name == RollName.SnakeEyes)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.CasinoCraps
{
    public class HiLoBet : Bet
    {
        public HiLoBet(int amount)
            : base(amount)
        {
        }

        public override int Odds
        {
            get
            {
                return 15;
            }
        }

        public override void DiceRolled(Roll roll)
        {
            if (roll.Name == RollName.SnakeEyes || roll.Name == RollName.Boxcars)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.CasinoCraps
{
    public class AceDeuceBet : Bet
    {
        public AceDeuceBet(int amount)
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
            if (roll.Name == RollName.AceDeuce)
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

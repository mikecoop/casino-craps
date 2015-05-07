using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.CasinoCraps
{
    public class DontComeBet : Bet
    {
        private readonly Round round;

        public DontComeBet(int amount)
            : base(amount)
        {
            round = new Round();
            round.RoundEnded += PrivateRoundEnded;
        }

        public override int Odds
        {
            get { return 1; }
        }

        public override void DiceRolled(Roll roll)
        {
            round.SetNextRoll(roll);
        }

        public override void RoundEnded(RoundEndedEventArgs args)
        {
            // Do nothing.
        }

        private void PrivateRoundEnded(object sender, RoundEndedEventArgs e)
        {
            switch (e.Result)
            {
                case RoundResult.Craps:
                    if (e.Roll.Name == RollName.Boxcars)
                    {
                        Status = BetStatus.Push;
                    }
                    else
                    {
                        Status = BetStatus.Won;
                    }
                    break;
                case RoundResult.Natural:
                    Status = BetStatus.Lost;
                    break;
                case RoundResult.PointHit:
                    Status = BetStatus.Lost;
                    break;
                case RoundResult.SevenOut:
                    Status = BetStatus.Won;
                    break;
                default:
                    break;
            }
        }
    }
}

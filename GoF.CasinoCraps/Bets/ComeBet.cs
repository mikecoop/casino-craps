using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.CasinoCraps
{
    public class ComeBet : Bet
    {
        private readonly Round round;

        public ComeBet(int amount)
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
                    Status = BetStatus.Lost;
                    break;
                case RoundResult.Natural:
                    Status = BetStatus.Won;
                    break;
                case RoundResult.PointHit:
                    Status = BetStatus.Won;
                    break;
                case RoundResult.SevenOut:
                    Status = BetStatus.Lost;
                    break;
                default:
                    break;
            }
        }
    }
}

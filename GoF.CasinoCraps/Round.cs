using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace GoF.CasinoCraps
{
    /// <summary>
    /// Represents a round of play in craps.
    /// </summary>
    public class Round
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Round"/> class.
        /// </summary>
        public Round()
        {
            Phase = RoundPhase.ComeOut;
        }

        public event EventHandler PointEstablished;

        public event EventHandler<RoundEndedEventArgs> RoundEnded;

        public int PointValue { get; private set; }

        public RoundPhase Phase { get; private set; }

        public void SetNextRoll(Roll roll)
        {
            Contract.Requires(roll != null);

            if (Phase == RoundPhase.ComeOut)
            {
                if (roll.IsCraps)
                {
                    EndRound(RoundResult.Craps);
                }
                else if (roll.IsNatural)
                {
                    EndRound(RoundResult.Natural);
                }
                else if (roll.IsPoint)
                {
                    EstablishPoint(roll);
                }
            }
            else
            {
                if (roll.DiceTotal == 7)
                {
                    EndRound(RoundResult.SevenOut);
                }
                else if (roll.DiceTotal == PointValue)
                {
                    EndRound(RoundResult.PointHit);
                }
            }
        }

        private void EstablishPoint(Roll roll)
        {
            if (PointEstablished != null)
            {
                PointEstablished(this, new EventArgs());
            }

            Phase = RoundPhase.Point;
            PointValue = roll.DiceTotal;
        }

        private void EndRound(RoundResult result)
        {
            if (RoundEnded != null)
            {
                RoundEnded(this, new RoundEndedEventArgs(result));
            }
        }
    }
}

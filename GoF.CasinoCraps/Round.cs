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
        private readonly List<int> CrapsRolls = new List<int> { 2, 3, 12 };
        private readonly List<int> NaturalRolls = new List<int> { 7, 11 };
        private readonly List<int> PointRolls = new List<int> { 4, 5, 6, 8, 9, 10 };

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
                if (CrapsRolls.Contains(roll.DiceTotal))
                {
                    EndRound(RoundResult.Craps);
                }
                else if (NaturalRolls.Contains(roll.DiceTotal))
                {
                    EndRound(RoundResult.Natural);
                }
                else if (PointRolls.Contains(roll.DiceTotal))
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

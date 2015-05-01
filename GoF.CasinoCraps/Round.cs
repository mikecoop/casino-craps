namespace GoF.CasinoCraps
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Linq;

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

        /// <summary>
        /// Occurs when a point has been established for the round.
        /// </summary>
        public event EventHandler PointEstablished;

        /// <summary>
        /// Occurs when the round ends.
        /// </summary>
        public event EventHandler<RoundEndedEventArgs> RoundEnded;

        /// <summary>
        /// Gets the currently established point value. Returns zero if no point has been established.
        /// </summary>
        public int PointValue { get; private set; }

        /// <summary>
        /// Gets the current phase of the round.
        /// </summary>
        public RoundPhase Phase { get; private set; }

        /// <summary>
        /// Sets the next roll for the round.
        /// </summary>
        /// <param name="roll">The next roll to set.</param>
        public void SetNextRoll(Roll roll)
        {
            Contract.Requires(roll != null);

            if (Phase == RoundPhase.ComeOut)
            {
                if (roll.IsCraps)
                {
                    EndRound(RoundResult.Craps, roll);  
                }
                else if (roll.IsNatural)
                {
                    EndRound(RoundResult.Natural, roll);
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
                    EndRound(RoundResult.SevenOut, roll);
                }
                else if (roll.DiceTotal == PointValue)
                {
                    EndRound(RoundResult.PointHit, roll);
                }
            }
        }

        /// <summary>
        /// Resets the round to initial values.
        /// </summary>
        public void Reset()
        {
            Phase = RoundPhase.ComeOut;
            PointValue = 0;
        }

        private void EstablishPoint(Roll roll)
        {
            Contract.Requires(roll != null);

            if (PointEstablished != null)
            {
                PointEstablished(this, new EventArgs());
            }

            Phase = RoundPhase.Point;
            PointValue = roll.DiceTotal;
        }

        private void EndRound(RoundResult result, Roll roll)
        {
            if (RoundEnded != null)
            {
                RoundEnded(this, new RoundEndedEventArgs(result, roll));
            }
        }
    }
}

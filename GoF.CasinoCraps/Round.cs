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

        public RoundPhase Phase { get; private set; }

        public void NextRoll(Roll roll)
        {
            Contract.Requires(roll != null);

            if (roll.DiceTotal == 4 ||
                roll.DiceTotal == 5 ||
                roll.DiceTotal == 6 ||
                roll.DiceTotal == 8 ||
                roll.DiceTotal == 9 ||
                roll.DiceTotal == 10)
            {
                Phase = RoundPhase.Point;
            }
        }
    }
}

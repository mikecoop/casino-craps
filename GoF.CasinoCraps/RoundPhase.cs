namespace GoF.CasinoCraps
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specifies the phase of a craps round.
    /// </summary>
    public enum RoundPhase
    {
        /// <summary>
        /// The come-out phase.
        /// </summary>
        ComeOut = 1,

        /// <summary>
        /// The point phase.
        /// </summary>
        Point = 2
    }
}

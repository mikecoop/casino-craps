namespace GoF.CasinoCraps
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Indicates the status of a bet in craps.
    /// </summary>
    public enum BetStatus
    {
        /// <summary>
        /// The bet is still active.
        /// </summary>
        Active = 1,

        /// <summary>
        /// The bet was lost.
        /// </summary>
        Lost = 2,

        /// <summary>
        /// The bet was won.
        /// </summary>
        Won = 3,

        /// <summary>
        /// The bet was pushed.
        /// </summary>
        Push = 4
    }
}

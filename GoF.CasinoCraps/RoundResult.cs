namespace GoF.CasinoCraps
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specifies the result of a round of craps.
    /// </summary>
    public enum RoundResult
    {
        /// <summary>
        /// The round ended with a craps roll.
        /// </summary>
        Craps = 1,

        /// <summary>
        /// The round ended with a natural roll.
        /// </summary>
        Natural = 2,

        /// <summary>
        /// The round ended with the point value hit.
        /// </summary>
        PointHit = 3,

        /// <summary>
        /// The round ended with seven out.
        /// </summary>
        SevenOut = 4
    }
}

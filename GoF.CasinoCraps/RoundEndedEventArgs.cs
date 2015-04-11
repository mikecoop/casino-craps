namespace GoF.CasinoCraps
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Provides data for the <see cref="Round.RoundEnded"/> event.
    /// </summary>
    public class RoundEndedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoundEndedEventArgs"/> class.
        /// </summary>
        /// <param name="result">The result of the round.</param>
        public RoundEndedEventArgs(RoundResult result)
        {
            Result = result;
        }

        /// <summary>
        /// Gets the result of the round.
        /// </summary>
        public RoundResult Result { get; private set; }
    }
}

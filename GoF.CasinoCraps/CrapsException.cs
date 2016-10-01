namespace GoF.CasinoCraps
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Thrown when an incorrect amount is entered for a bet.
    /// </summary>
    [Serializable]
    public class CrapsException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CrapsException"/> class.
        /// </summary>
        public CrapsException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CrapsException"/> class.
        /// </summary>
        /// <param name="message">The error message.</param>
        public CrapsException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CrapsException"/> class.
        /// </summary>
        /// <param name="message">The error message.</param>
        /// <param name="innerException">The inner exception.</param>
        public CrapsException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CrapsException"/> class.
        /// </summary>
        /// <param name="info">The serialization info.</param>
        /// <param name="context">The streaming context.</param>
        protected CrapsException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
    }
}

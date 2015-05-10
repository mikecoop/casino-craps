namespace GoF.CasinoCraps
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a bet in craps.
    /// </summary>
    public abstract class Bet
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Bet"/> class.
        /// (Requirement 3.2.1)
        /// (Requirement 3.2.2)
        /// </summary>
        /// <param name="amount">The amount of the bet.</param>
        public Bet(int amount)
        {
            Status = BetStatus.Active;
            Amount = amount;
        }

        /// <summary>
        /// Gets the name of the bet.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Gets the ID of the bet.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Gets the player that made the bet.
        /// </summary>
        public Player Player { get; private set; }

        /// <summary>
        /// Gets or sets the current status of the bet.
        /// </summary>
        public BetStatus Status { get; protected set; }

        /// <summary>
        /// Gets or sets the amount of the bet.
        /// </summary>
        public int Amount { get; protected set; }

        /// <summary>
        /// Gets the payout amount of the bet including the initial wager.
        /// </summary>
        public virtual int PayoutAmount
        {
            get
            {
                if (Status == BetStatus.Won)
                {
                    return Amount + Convert.ToInt32(Amount * Odds);
                }
                else if (Status == BetStatus.Push)
                {
                    return Amount;
                }

                return 0;
            }
        }

        /// <summary>
        /// Gets the payout odds of the bet.
        /// (Requirement 3.7.0)
        /// </summary>
        public abstract int Odds { get; }

        /// <summary>
        /// Notifies the bet that the dice have been rolled.
        /// </summary>
        /// <param name="roll">The roll.</param>
        public abstract void DiceRolled(Roll roll);

        /// <summary>
        /// Notifies the bet that the round has ended.
        /// </summary>
        /// <param name="args">The RoundEndedEventArgs arguments.</param>
        public abstract void RoundEnded(RoundEndedEventArgs args);

        /// <summary>
        /// Sets the player for the current bet.
        /// </summary>
        /// <param name="player">The player to set.</param>
        public void SetPlayer(Player player)
        {
            Player = player;
        }

        /// <summary>
        /// Sets the ID for the current bet.
        /// </summary>
        /// <param name="id">The ID to set.</param>
        public void SetId(int id)
        {
            Id = id;
        }

        public override string ToString()
        {
            if (Status == BetStatus.Active)
            {
                return string.Format("{0} ${1}", Name, Amount);
            }
            else
            {
                return string.Format("{0} {1} - Payout Amount ${2}", Name, Enum.GetName(typeof(BetStatus), Status), PayoutAmount);
            }
        }
    }
}

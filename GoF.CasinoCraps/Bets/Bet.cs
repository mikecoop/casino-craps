using System;
using System.Collections.Generic;
using System.Linq;

namespace GoF.CasinoCraps
{
    /// <summary>
    /// Represents a bet in craps.
    /// </summary>
    public abstract class Bet
    {
        public Bet(int amount)
        {
            Status = BetStatus.Active;
            Amount = amount;
        }

        public int Id { get; private set; }

        public Player Player { get; private set; }

        public BetStatus Status { get; protected set; }

        public int Amount { get; protected set; }

        public int PayoutAmount
        {
            get
            {
                if (Status == BetStatus.Won)
                {
                    return Amount + Amount * Odds;
                }
                else if (Status == BetStatus.Push)
                {
                    return Amount;
                }

                return 0;
            }
        }

        public abstract int Odds { get; }

        public abstract void DiceRolled(Roll roll);

        public abstract void RoundEnded(RoundEndedEventArgs args);

        public void SetPlayer(Player player)
        {
            Player = player;
        }

        public void SetId(int id)
        {
            Id = id;
        }
    }
}

namespace GoF.CasinoCraps
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a player of craps.
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Player"/> class.
        /// </summary>
        /// <param name="money">The amount of money the player starts with.</param>
        public Player(int money)
        {
            Money = money;
        }

        /// <summary>
        /// Gets the game the player is playing.
        /// </summary>
        public IGame Game { get; private set; }

        /// <summary>
        /// Gets the amount of money the player has.
        /// </summary>
        public int Money { get; private set; }

        /// <summary>
        /// Joins the given game.
        /// </summary>
        /// <param name="game">The game to join.</param>
        public void JoinGame(IGame game)
        {
            Game = game;
        }

        /// <summary>
        /// Adds the given amount of money to the player's money.
        /// </summary>
        /// <param name="amount">The amount of money to add.</param>
        public void AddMoney(int amount)
        {
            Money += amount;
        }

        /// <summary>
        /// Places the given bet for the current game.
        /// </summary>
        /// <param name="bet">The bet to place.</param>
        public void PlaceBet(Bet bet)
        {
            bet.SetPlayer(this);
            Money -= bet.Amount;
            Game.PlaceBet(bet);
        }

        /// <summary>
        /// Rolls the dice for the current game.
        /// </summary>
        /// <returns>The resulting roll.</returns>
        public Roll RollDice()
        {
            return Game.RollDice();
        }

        /// <summary>
        /// Rolls the dice for the current game.
        /// </summary>
        /// <param name="firstDie">The first die value.</param>
        /// <param name="secondDie">The second die value.</param>
        /// <returns>The resulting roll.</returns>
        public Roll RollDice(int firstDie, int secondDie)
        {
            return Game.RollDice(firstDie, secondDie);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.CasinoCraps
{
    public class Player
    {
        public Player(int money)
        {
            Money = money;
        }

        public IGame Game { get; private set; }

        public int Money { get; private set; }

        public void JoinGame(IGame game)
        {
            Game = game;
        }

        public void AddMoney(int amount)
        {
            Money += amount;
        }

        public void PlaceBet(Bet bet)
        {
            bet.SetPlayer(this);
            Money -= bet.Amount;
            Game.PlaceBet(bet);
        }

        public Roll RollDice()
        {
            return Game.RollDice();
        }

        public Roll RollDice(int firstDie, int secondDie)
        {
            return Game.RollDice(firstDie, secondDie);
        }
    }
}

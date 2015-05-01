using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FluentAssertions;

namespace GoF.CasinoCraps.Tests
{
    public class CAndEBetTests
    {
        private Game game;

        [SetUp]
        public void Setup()
        {
            game = new Game();
        }

        [Test]
        public void Status_CAndEBetCrapsRolled_IsWon()
        {
            game.PlaceBet(new CAndEBet(200));

            game.RollDice(1, 1);

            Bet bet = game.CompletedBets.First();

            bet.Status.Should().Be(BetStatus.Won);
        }

        [Test]
        public void PayoutAmount_CAndEBetCrapsRolled_ReturnsCorrectAmount()
        {
            game.PlaceBet(new CAndEBet(200));

            game.RollDice(1, 1);

            Bet bet = game.CompletedBets.First();

            bet.PayoutAmount.Should().Be(400);
        }

        [Test]
        public void Status_CAndEBetElevenRolled_IsWon()
        {
            game.PlaceBet(new CAndEBet(200));

            game.RollDice(6, 5);

            Bet bet = game.CompletedBets.First();

            bet.Status.Should().Be(BetStatus.Won);
        }

        [Test]
        public void PayoutAmount_CAndEBetElevenRolled_ReturnsCorrectAmount()
        {
            game.PlaceBet(new CAndEBet(200));

            game.RollDice(5, 6);

            Bet bet = game.CompletedBets.First();

            bet.PayoutAmount.Should().Be(800);
        }

        [Test]
        public void Status_CAndEBetCrapsOrElevenNotRolled_IsLost()
        {
            game.PlaceBet(new CAndEBet(200));

            game.RollDice(1, 4);

            Bet bet = game.CompletedBets.First();

            bet.Status.Should().Be(BetStatus.Lost);
        }

        [Test]
        public void PayoutAmount_CAndEBetCrapsOrElevenNotRolled_ReturnsCorrectAmount()
        {
            game.PlaceBet(new CAndEBet(200));

            game.RollDice(1, 4);

            Bet bet = game.CompletedBets.First();

            bet.PayoutAmount.Should().Be(0);
        }
    }
}

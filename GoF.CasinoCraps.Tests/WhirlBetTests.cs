using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using GoF.CasinoCraps;

namespace GoF.CasinoCraps.Tests
{
    public class WhirlBetTests
    {
        private Game game;

        [SetUp]
        public void Setup()
        {
            game = new Game();
        }

        [Test]
        public void Status_WhirlBetPlacedTwoRolled_IsWon()
        {
            game.PlaceBet(new WhirlBet(5));

            game.RollDice(1, 1);

            Bet bet = game.CompletedBets.First();

            bet.Status.Should().Be(BetStatus.Won);
        }

        [Test]
        public void PayoutAmount_WhirlBetPlacedTwoRolled_ReturnsCorrectAmount()
        {
            game.PlaceBet(new WhirlBet(5));

            game.RollDice(1, 1);

            Bet bet = game.CompletedBets.First();

            bet.PayoutAmount.Should().Be(27);
        }

        [Test]
        public void Status_WhirlBetPlacedThreeRolled_IsWon()
        {
            game.PlaceBet(new WhirlBet(5));

            game.RollDice(1, 2);

            Bet bet = game.CompletedBets.First();

            bet.Status.Should().Be(BetStatus.Won);
        }

        [Test]
        public void PayoutAmount_WhirlBetPlacedThreeRolled_ReturnsCorrectAmount()
        {
            game.PlaceBet(new WhirlBet(5));

            game.RollDice(1, 2);

            Bet bet = game.CompletedBets.First();

            bet.PayoutAmount.Should().Be(12);
        }

        [Test]
        public void Status_WhirlBetPlacedElevenRolled_IsWon()
        {
            game.PlaceBet(new WhirlBet(5));

            game.RollDice(5, 6);

            Bet bet = game.CompletedBets.First();

            bet.Status.Should().Be(BetStatus.Won);
        }

        [Test]
        public void PayoutAmount_WhirlBetPlacedElevenRolled_ReturnsCorrectAmount()
        {
            game.PlaceBet(new WhirlBet(5));

            game.RollDice(5, 6);

            Bet bet = game.CompletedBets.First();

            bet.PayoutAmount.Should().Be(12);
        }

        [Test]
        public void Status_WhirlBetPlacedTwelveRolled_IsWon()
        {
            game.PlaceBet(new WhirlBet(5));

            game.RollDice(6, 6);

            Bet bet = game.CompletedBets.First();

            bet.Status.Should().Be(BetStatus.Won);
        }

        [Test]
        public void PayoutAmount_WhirlBetPlacedTwelveRolled_ReturnsCorrectAmount()
        {
            game.PlaceBet(new WhirlBet(5));

            game.RollDice(6, 6);

            Bet bet = game.CompletedBets.First();

            bet.PayoutAmount.Should().Be(27);
        }

        [Test]
        public void Status_WhirlBetPlacedSevenRolled_IsPush()
        {
            game.PlaceBet(new WhirlBet(5));

            game.RollDice(1, 6);

            Bet bet = game.CompletedBets.First();

            bet.Status.Should().Be(BetStatus.Push);
        }

        [Test]
        public void PayoutAmount_WhirlBetPlacedSevenRolled_ReturnsCorrectAmount()
        {
            game.PlaceBet(new WhirlBet(5));

            game.RollDice(1, 6);

            Bet bet = game.CompletedBets.First();

            bet.PayoutAmount.Should().Be(1);
        }
    }
}

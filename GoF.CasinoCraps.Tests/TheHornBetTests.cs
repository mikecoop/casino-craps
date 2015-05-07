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
    public class TheHornBetTests
    {
        private Game game;

        [SetUp]
        public void Setup()
        {
            game = new Game();
        }

        [Test]
        public void Status_TheHornBetPlacedTwoRolled_IsWon()
        {
            game.PlaceBet(new TheHornBet(4));

            game.RollDice(1, 1);

            Bet bet = game.CompletedBets.First();

            bet.Status.Should().Be(BetStatus.Won);
        }

        [Test]
        public void PayoutAmount_TheHornBetPlacedTwoRolled_ReturnsCorrectAmount()
        {
            game.PlaceBet(new TheHornBet(4));

            game.RollDice(1, 1);

            Bet bet = game.CompletedBets.First();

            bet.PayoutAmount.Should().Be(28);
        }

        [Test]
        public void Status_TheHornBetPlacedThreeRolled_IsWon()
        {
            game.PlaceBet(new TheHornBet(4));

            game.RollDice(1, 2);

            Bet bet = game.CompletedBets.First();

            bet.Status.Should().Be(BetStatus.Won);
        }

        [Test]
        public void PayoutAmount_TheHornBetPlacedThreeRolled_ReturnsCorrectAmount()
        {
            game.PlaceBet(new TheHornBet(4));

            game.RollDice(1, 2);

            Bet bet = game.CompletedBets.First();

            bet.PayoutAmount.Should().Be(13);
        }

        [Test]
        public void Status_TheHornBetPlacedElevenRolled_IsWon()
        {
            game.PlaceBet(new TheHornBet(4));

            game.RollDice(5, 6);

            Bet bet = game.CompletedBets.First();

            bet.Status.Should().Be(BetStatus.Won);
        }

        [Test]
        public void PayoutAmount_TheHornBetPlacedElevenRolled_ReturnsCorrectAmount()
        {
            game.PlaceBet(new TheHornBet(4));

            game.RollDice(5, 6);

            Bet bet = game.CompletedBets.First();

            bet.PayoutAmount.Should().Be(13);
        }

        [Test]
        public void Status_TheHornBetPlacedTwelveRolled_IsWon()
        {
            game.PlaceBet(new TheHornBet(4));

            game.RollDice(6, 6);

            Bet bet = game.CompletedBets.First();

            bet.Status.Should().Be(BetStatus.Won);
        }

        [Test]
        public void PayoutAmount_TheHornBetPlacedTwelveRolled_ReturnsCorrectAmount()
        {
            game.PlaceBet(new TheHornBet(4));

            game.RollDice(6, 6);

            Bet bet = game.CompletedBets.First();

            bet.PayoutAmount.Should().Be(28);
        }
    }
}

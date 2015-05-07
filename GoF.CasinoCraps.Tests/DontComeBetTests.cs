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
    public class DontComeBetTests
    {
        private Game game;

        [SetUp]
        public void Setup()
        {
            game = new Game();
        }

        [Test]
        public void Status_PointEstablishedPointHit_IsLost()
        {
            Bet bet = new DontComeBet(10);

            game.PlaceBet(bet);

            game.RollDice(4, 4);
            game.RollDice(4, 4);

            bet.Status.Should().Be(BetStatus.Lost);
        }

        [Test]
        public void Status_PointEstablishedSevenOut_IsWon()
        {
            Bet bet = new DontComeBet(10);

            game.PlaceBet(bet);

            game.RollDice(4, 4);
            game.RollDice(4, 3);

            bet.Status.Should().Be(BetStatus.Won);
        }

        [Test]
        public void Status_NaturalRolled_IsLost()
        {
            Bet bet = new DontComeBet(10);

            game.PlaceBet(bet);

            game.RollDice(5, 6);

            bet.Status.Should().Be(BetStatus.Lost);
        }

        [Test]
        public void Status_CrapsRolled_IsWon()
        {
            Bet bet = new DontComeBet(10);

            game.PlaceBet(bet);

            game.RollDice(1, 1);

            bet.Status.Should().Be(BetStatus.Won);
        }

        [Test]
        public void Status_BoxcarsRolled_IsPush()
        {
            Bet bet = new DontComeBet(10);

            game.PlaceBet(bet);

            game.RollDice(6, 6);

            bet.Status.Should().Be(BetStatus.Push);
        }

        [Test]
        public void PayoutAmount_CrapsRolled_IsCorrectAmount()
        {
            Bet bet = new DontComeBet(10);

            game.PlaceBet(bet);

            game.RollDice(1, 1);

            bet.PayoutAmount.Should().Be(20);
        }
    }
}

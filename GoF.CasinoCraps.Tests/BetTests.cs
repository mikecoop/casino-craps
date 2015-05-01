using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FluentAssertions;
using GoF.CasinoCraps;

namespace GoF.CasinoCraps.Tests
{
    public class BetTests
    {
        private Game game;

        [SetUp]
        public void Setup()
        {
            game = new Game();
        }

        [Test]
        public void Status_SnakeEyesBetSnakeEyesRolled_IsWon()
        {
            game.PlaceBet(new SnakeEyesBet(200));

            game.RollDice(1, 1);

            Bet bet = game.CompletedBets.First();

            bet.Status.Should().Be(BetStatus.Won);
        }

        [Test]
        public void PayoutAmount_SnakeEyesBetSnakeEyesRolled_IsCorrect()
        {
            game.PlaceBet(new SnakeEyesBet(200));

            game.RollDice(1, 1);

            Bet bet = game.CompletedBets.First();

            bet.PayoutAmount.Should().Be(6200);
        }

        [Test]
        public void Status_SnakeEyesBetSnakeEyesNotRolled_IsLost()
        {
            game.PlaceBet(new SnakeEyesBet(200));

            game.RollDice(1, 2);

            Bet bet = game.CompletedBets.First();

            bet.Status.Should().Be(BetStatus.Lost);
        }

        [Test]
        public void PayoutAmount_SnakeEyesBetSnakeEyesNotRolled_IsCorrect()
        {
            game.PlaceBet(new SnakeEyesBet(200));

            game.RollDice(1, 2);

            Bet bet = game.CompletedBets.First();

            bet.PayoutAmount.Should().Be(0);
        }

        [Test]
        public void Status_AceDeuceBetAceDeuceRolled_IsWon()
        {
            game.PlaceBet(new AceDeuceBet(10));

            game.RollDice(1, 2);

            Bet bet = game.CompletedBets.First();

            bet.Status.Should().Be(BetStatus.Won);
        }

        [Test]
        public void PayoutAmount_AceDeuceBetAceDeuceRolled_IsCorrect()
        {
            game.PlaceBet(new AceDeuceBet(10));

            game.RollDice(2, 1);

            Bet bet = game.CompletedBets.First();

            bet.PayoutAmount.Should().Be(160);
        }

        [Test]
        public void Status_AceDeuceBetAceDeuceNotRolled_IsLost()
        {
            game.PlaceBet(new AceDeuceBet(10));

            game.RollDice(2, 2);

            Bet bet = game.CompletedBets.First();

            bet.Status.Should().Be(BetStatus.Lost);
        }

        [Test]
        public void PayoutAmount_AceDeuceBetAceDeuceNotRolled_IsCorrect()
        {
            game.PlaceBet(new AceDeuceBet(10));

            game.RollDice(2, 2);

            Bet bet = game.CompletedBets.First();

            bet.PayoutAmount.Should().Be(0);
        }

        [Test]
        public void Status_YoBetYoRolled_IsWon()
        {
            game.PlaceBet(new YoBet(10));

            game.RollDice(5, 6);

            Bet bet = game.CompletedBets.First();

            bet.Status.Should().Be(BetStatus.Won);
        }

        [Test]
        public void PayoutAmount_YoBetYoRolled_IsCorrect()
        {
            game.PlaceBet(new YoBet(10));

            game.RollDice(6, 5);

            Bet bet = game.CompletedBets.First();

            bet.PayoutAmount.Should().Be(160);
        }

        [Test]
        public void Status_YoBetYoNotRolled_IsLost()
        {
            game.PlaceBet(new YoBet(10));

            game.RollDice(2, 2);

            Bet bet = game.CompletedBets.First();

            bet.Status.Should().Be(BetStatus.Lost);
        }

        [Test]
        public void PayoutAmount_YoBetYoNotRolled_IsCorrect()
        {
            game.PlaceBet(new YoBet(10));

            game.RollDice(2, 2);

            Bet bet = game.CompletedBets.First();

            bet.PayoutAmount.Should().Be(0);
        }

        [Test]
        public void Status_BoxcarsBetBoxcarsRolled_IsWon()
        {
            game.PlaceBet(new BoxcarsBet(10));

            game.RollDice(6, 6);

            Bet bet = game.CompletedBets.First();

            bet.Status.Should().Be(BetStatus.Won);
        }

        [Test]
        public void PayoutAmount_BoxcarsBetBoxcarsRolled_IsCorrect()
        {
            game.PlaceBet(new BoxcarsBet(10));

            game.RollDice(6, 6);

            Bet bet = game.CompletedBets.First();

            bet.PayoutAmount.Should().Be(310);
        }

        [Test]
        public void Status_BoxcarsBetBoxcarsNotRolled_IsLost()
        {
            game.PlaceBet(new BoxcarsBet(10));

            game.RollDice(2, 2);

            Bet bet = game.CompletedBets.First();

            bet.Status.Should().Be(BetStatus.Lost);
        }

        [Test]
        public void PayoutAmount_BoxcarsBetBoxcarsNotRolled_IsCorrect()
        {
            game.PlaceBet(new BoxcarsBet(10));

            game.RollDice(2, 2);

            Bet bet = game.CompletedBets.First();

            bet.PayoutAmount.Should().Be(0);
        }

        [Test]
        public void Status_HiLoBetTwoRolled_IsWon()
        {
            game.PlaceBet(new HiLoBet(10));

            game.RollDice(1, 1);

            Bet bet = game.CompletedBets.First();

            bet.Status.Should().Be(BetStatus.Won);
        }

        [Test]
        public void PayoutAmount_HiLoBetTwoRolled_IsCorrect()
        {
            game.PlaceBet(new HiLoBet(10));

            game.RollDice(1, 1);

            Bet bet = game.CompletedBets.First();

            bet.PayoutAmount.Should().Be(160);
        }

        [Test]
        public void Status_HiLoBetTwelveRolled_IsWon()
        {
            game.PlaceBet(new HiLoBet(10));

            game.RollDice(6, 6);

            Bet bet = game.CompletedBets.First();

            bet.Status.Should().Be(BetStatus.Won);
        }

        [Test]
        public void PayoutAmount_HiLoBetTwelveRolled_IsCorrect()
        {
            game.PlaceBet(new HiLoBet(10));

            game.RollDice(6, 6);

            Bet bet = game.CompletedBets.First();

            bet.PayoutAmount.Should().Be(160);
        }

        [Test]
        public void Status_HiLoBetHiLoNotRolled_IsLost()
        {
            game.PlaceBet(new HiLoBet(10));

            game.RollDice(2, 2);

            Bet bet = game.CompletedBets.First();

            bet.Status.Should().Be(BetStatus.Lost);
        }

        [Test]
        public void PayoutAmount_HiLoBetHiLoNotRolled_IsCorrect()
        {
            game.PlaceBet(new HiLoBet(10));

            game.RollDice(2, 2);

            Bet bet = game.CompletedBets.First();

            bet.PayoutAmount.Should().Be(0);
        }

        [Test]
        public void Status_AnyCrapsBetTwoRolled_IsWon()
        {
            game.PlaceBet(new AnyCrapsBet(10));

            game.RollDice(1, 1);

            Bet bet = game.CompletedBets.First();

            bet.Status.Should().Be(BetStatus.Won);
        }

        [Test]
        public void PayoutAmount_AnyCrapsBetTwoRolled_IsCorrect()
        {
            game.PlaceBet(new AnyCrapsBet(10));

            game.RollDice(1, 1);

            Bet bet = game.CompletedBets.First();

            bet.PayoutAmount.Should().Be(80);
        }

        [Test]
        public void Status_AnyCrapsBetThreeRolled_IsWon()
        {
            game.PlaceBet(new AnyCrapsBet(10));

            game.RollDice(1, 1);

            Bet bet = game.CompletedBets.First();

            bet.Status.Should().Be(BetStatus.Won);
        }

        [Test]
        public void PayoutAmount_AnyCrapsBetThreeRolled_IsCorrect()
        {
            game.PlaceBet(new AnyCrapsBet(10));

            game.RollDice(1, 1);

            Bet bet = game.CompletedBets.First();

            bet.PayoutAmount.Should().Be(80);
        }

        [Test]
        public void Status_AnyCrapsBetTwelveRolled_IsWon()
        {
            game.PlaceBet(new AnyCrapsBet(10));

            game.RollDice(6, 6);

            Bet bet = game.CompletedBets.First();

            bet.Status.Should().Be(BetStatus.Won);
        }

        [Test]
        public void PayoutAmount_AnyCrapsBetTwelveRolled_IsCorrect()
        {
            game.PlaceBet(new AnyCrapsBet(10));

            game.RollDice(6, 6);

            Bet bet = game.CompletedBets.First();

            bet.PayoutAmount.Should().Be(80);
        }

        [Test]
        public void Status_AnyCrapsBetAnyCrapsNotRolled_IsLost()
        {
            game.PlaceBet(new AnyCrapsBet(10));

            game.RollDice(2, 2);

            Bet bet = game.CompletedBets.First();

            bet.Status.Should().Be(BetStatus.Lost);
        }

        [Test]
        public void PayoutAmount_AnyCrapsBetAnyCrapsNotRolled_IsCorrect()
        {
            game.PlaceBet(new AnyCrapsBet(10));

            game.RollDice(2, 2);

            Bet bet = game.CompletedBets.First();

            bet.PayoutAmount.Should().Be(0);
        }

        [Test]
        public void Status_AnySevenBetSevenRolled_IsWon()
        {
            game.PlaceBet(new AnySevenBet(10));

            game.RollDice(1, 6);

            Bet bet = game.CompletedBets.First();

            bet.Status.Should().Be(BetStatus.Won);
        }

        [Test]
        public void PayoutAmount_AnySevenBetSevenRolled_IsCorrect()
        {
            game.PlaceBet(new AnySevenBet(10));

            game.RollDice(3, 4);

            Bet bet = game.CompletedBets.First();

            bet.PayoutAmount.Should().Be(50);
        }

        [Test]
        public void Id_BetsPlaced_IsIncremented()
        {
            game.PlaceBet(new AnySevenBet(10));

            Bet bet = new BoxcarsBet(20);

            game.PlaceBet(bet);

            bet.Id.Should().Be(2);
        }
    }
}

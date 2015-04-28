using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using GoF.CasinoCraps;
using FluentAssertions;
using System.Text.RegularExpressions;

namespace GoF.CasinoCraps.Tests
{
    [TestFixture]
    public class GameTests
    {
        private Game game;

        [SetUp]
        public void Setup()
        {
            game = new Game();
        }

        private readonly string DiceRegex = string.Format("{0}[1-6]{1}", Regex.Escape("["), Regex.Escape("]"));
        private readonly string TotalRegex = string.Format("{0}[1-9]|10|11|12{1}", Regex.Escape("("), Regex.Escape(")"));

        [Test]
        public void Execute_GivenRollCommand_ReturnsCorrectValue()
        {
            string output = game.Execute("roll");

            output.Should().MatchRegex(string.Format("roll #1 - {0} {0} - {1}", DiceRegex, TotalRegex));
        }

        [Test]
        public void Execute_SecondRoll_RollNumberIsIncremented()
        {
            game.Execute("roll");
            string output = game.Execute("roll");

            output.Should().MatchRegex(string.Format("roll #2 - {0} {0} - {1}", DiceRegex, TotalRegex));
        }

        [Test]
        public void Execute_RollWithValues_ReturnsCorrectValues()
        {
            game.Execute("roll");
            game.Execute("roll");
            string output = game.Execute("roll 1 6");

            output.Should().Be("roll #3 - [1] [6] - (7)");
        }

        [Test]
        public void Execute_NewGame_RollsAreReset()
        {
            game.Execute("roll");
            game.Execute("roll");

            game.Execute("new-game");
            string output = game.Execute("roll 1 6");

            output.Should().Be("roll #1 - [1] [6] - (7)");
        }

        [Test]
        public void RollNumber_WhenCreated_IsOne()
        {
            game.RollNumber.Should().Be(1);
        }

        [Test]
        public void RoundNumber_WhenCreated_IsOne()
        {
            game.RoundNumber.Should().Be(1);
        }

        [Test]
        public void RoundNumber_RoundEnded_IsIncremented()
        {
            game.Execute("roll 1 6");

            game.RoundNumber.Should().Be(2);
        }

        [Test]
        public void RoundNumber_RoundEndedTwice_IsIncremented()
        {
            game.Execute("roll 1 6");
            game.Execute("roll 6 6");

            game.RoundNumber.Should().Be(3);
        }

        [Test]
        public void RollDice_NewGame_DiceAreRolled()
        {
            game.RollDice();

            game.RollNumber.Should().Be(2);
        }

        [Test]
        public void RollDice_WhenCalled_ReturnsDiceRoll()
        {
            Roll roll = game.RollDice();

            roll.Should().NotBeNull();
            roll.FirstDie.Should().NotBe(0);
            roll.SecondDie.Should().NotBe(0);
        }

        [Test]
        public void RollDice_GivenValues_DiceAreRolled()
        {
            game.RollDice(2, 3);

            game.RollNumber.Should().Be(2);
        }

        [Test]
        public void RollDice_GivenValues_ReturnsDiceRoll()
        {
            Roll roll = game.RollDice(2, 3);

            roll.Should().NotBeNull();
            roll.FirstDie.Should().Be(2);
            roll.SecondDie.Should().Be(3);
        }

        [Test]
        public void Restart_GameIsStarted_ResetsRollNumber()
        {
            game.RollDice();
            game.RollDice();

            game.Restart();

            game.RollNumber.Should().Be(1);
        }

        [Test]
        public void Restart_GameIsStarted_ResetsRoundNumber()
        {
            game.RollDice(1, 6);
            game.RollDice(1, 6);

            game.Restart();

            game.RoundNumber.Should().Be(1);
        }

        [Test]
        public void Restart_RoundInProgress_ResetsRound()
        {
            game.RollDice(2, 6);

            game.Restart();

            // Should not hit the point.
            game.RollDice(2, 6);

            game.RoundNumber.Should().Be(1);
        }
    }
}

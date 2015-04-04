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
    }
}

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using GoF.CasinoCraps;
using FluentAssertions;

namespace GoF.CasinoCraps.Tests
{
    [TestFixture]
    public class DiceRollTests
    {
        [Test]
        public void Constructor_PassedValues_HasCorrectValues()
        {
            DiceRoll diceRoll = new DiceRoll(1, 5);

            diceRoll.FirstDie.Should().Be(1);
            diceRoll.SecondDie.Should().Be(5);
        }

        [Test]
        public void Constructor_Empty_HasRandomValues()
        {
            DiceRoll diceRoll = new DiceRoll();

            diceRoll.FirstDie.Should().BeGreaterThan(0).And.BeLessOrEqualTo(6);
            diceRoll.SecondDie.Should().BeGreaterThan(0).And.BeLessOrEqualTo(6);
        }

        [Test]
        public void Next_WhenCalled_ReturnsDiceRoll()
        {
            DiceRoll diceRoll = DiceRoll.Next();

            diceRoll.FirstDie.Should().BeGreaterThan(0).And.BeLessOrEqualTo(6);
            diceRoll.SecondDie.Should().BeGreaterThan(0).And.BeLessOrEqualTo(6);
        }
    }
}

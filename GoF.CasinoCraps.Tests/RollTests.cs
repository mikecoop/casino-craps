using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using GoF.CasinoCraps;
using FluentAssertions;

namespace GoF.CasinoCraps.Tests
{
    [TestFixture]
    public class RollTests
    {
        [Test]
        public void Constructor_PassedValues_HasCorrectValues()
        {
            Roll roll = new Roll(1, 5);

            roll.FirstDie.Should().Be(1);
            roll.SecondDie.Should().Be(5);
        }

        [Test]
        public void Constructor_Empty_HasRandomValues()
        {
            Roll roll = new Roll();

            roll.FirstDie.Should().BeGreaterThan(0).And.BeLessOrEqualTo(6);
            roll.SecondDie.Should().BeGreaterThan(0).And.BeLessOrEqualTo(6);
        }

        [Test]
        public void Name_GivenSnakeEyesRoll_ReturnsCorrectName()
        {
            Roll roll = new Roll(1, 1);

            roll.Name.Should().Be(RollName.SnakeEyes);
        }

        [Test]
        public void Name_GivenAceDeuceRoll_ReturnsCorrectName()
        {
            Roll roll = new Roll(1, 2);
            roll.Name.Should().Be(RollName.AceDeuce);

            roll = new Roll(2, 1);
            roll.Name.Should().Be(RollName.AceDeuce);
        }

        [Test]
        public void Name_GivenEasyFour_ReturnsCorrectName()
        {
            Roll roll = new Roll(1, 3);
            roll.Name.Should().Be(RollName.EasyFour);

            roll = new Roll(3, 1);
            roll.Name.Should().Be(RollName.EasyFour);
        }

        [Test]
        public void Name_GivenHardFour_ReturnsCorrectName()
        {
            Roll roll = new Roll(2, 2);
            roll.Name.Should().Be(RollName.HardFour);
        }

        [Test]
        public void Name_GivenFive_ReturnsCorrectName()
        {
            Roll roll = new Roll(1, 4);
            roll.Name.Should().Be(RollName.Five);

            roll = new Roll(2, 3);
            roll.Name.Should().Be(RollName.Five);

            roll = new Roll(3, 2);
            roll.Name.Should().Be(RollName.Five);

            roll = new Roll(4, 1);
            roll.Name.Should().Be(RollName.Five);
        }

        [Test]
        public void Name_GivenEasySix_ReturnsCorrectName()
        {
            Roll roll = new Roll(1, 5);
            roll.Name.Should().Be(RollName.EasySix);

            roll = new Roll(2, 4);
            roll.Name.Should().Be(RollName.EasySix);

            roll = new Roll(4, 2);
            roll.Name.Should().Be(RollName.EasySix);

            roll = new Roll(5, 1);
            roll.Name.Should().Be(RollName.EasySix);
        }

        [Test]
        public void Name_GivenHardSix_ReturnsCorrectName()
        {
            Roll roll = new Roll(3, 3);
            roll.Name.Should().Be(RollName.HardSix);
        }

        [Test]
        public void Name_GivenSeven_ReturnsCorrectName()
        {
            Roll roll = new Roll(1, 6);
            roll.Name.Should().Be(RollName.Natural);

            roll = new Roll(2, 5);
            roll.Name.Should().Be(RollName.Natural);

            roll = new Roll(3, 4);
            roll.Name.Should().Be(RollName.Natural);

            roll = new Roll(4, 3);
            roll.Name.Should().Be(RollName.Natural);

            roll = new Roll(5, 2);
            roll.Name.Should().Be(RollName.Natural);

            roll = new Roll(6, 1);
            roll.Name.Should().Be(RollName.Natural);
        }

        [Test]
        public void Name_GivenEasyEight_ReturnsCorrectName()
        {
            Roll roll = new Roll(2, 6);
            roll.Name.Should().Be(RollName.EasyEight);

            roll = new Roll(3, 5);
            roll.Name.Should().Be(RollName.EasyEight);

            roll = new Roll(5, 3);
            roll.Name.Should().Be(RollName.EasyEight);

            roll = new Roll(6, 2);
            roll.Name.Should().Be(RollName.EasyEight);
        }

        [Test]
        public void Name_GivenHardEight_ReturnsCorrectName()
        {
            Roll roll = new Roll(4, 4);
            roll.Name.Should().Be(RollName.HardEight);
        }

        [Test]
        public void Name_GivenNine_ReturnsCorrectName()
        {
            Roll roll = new Roll(3, 6);
            roll.Name.Should().Be(RollName.Nine);

            roll = new Roll(4, 5);
            roll.Name.Should().Be(RollName.Nine);

            roll = new Roll(5, 4);
            roll.Name.Should().Be(RollName.Nine);

            roll = new Roll(6, 3);
            roll.Name.Should().Be(RollName.Nine);
        }

        [Test]
        public void Name_GivenEasyTen_ReturnsCorrectName()
        {
            Roll roll = new Roll(4, 6);
            roll.Name.Should().Be(RollName.EasyTen);

            roll = new Roll(6, 4);
            roll.Name.Should().Be(RollName.EasyTen);
        }

        [Test]
        public void Name_GivenHardTen_ReturnsCorrectName()
        {
            Roll roll = new Roll(5, 5);
            roll.Name.Should().Be(RollName.HardTen);
        }

        [Test]
        public void Name_GivenYo_ReturnsCorrectName()
        {
            Roll roll = new Roll(5, 6);
            roll.Name.Should().Be(RollName.Yo);

            roll = new Roll(6, 5);
            roll.Name.Should().Be(RollName.Yo);
        }

        [Test]
        public void Name_GivenBoxcars_ReturnsCorrectName()
        {
            Roll roll = new Roll(6, 6);
            roll.Name.Should().Be(RollName.Boxcars);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using GoF.CasinoCraps;
using FluentAssertions;

namespace GoF.CasinoCraps.Tests
{
    public class RoundTests
    {
        [Test]
        public void Phase_WhenCreated_IsComeOut()
        {
            Round round = new Round();

            round.Phase.Should().Be(RoundPhase.ComeOut);
        }

        [Test]
        public void Phase_FourPointRolled_IsPoint()
        {
            Round round = new Round();

            round.NextRoll(new Roll(3, 1));
            
            round.Phase.Should().Be(RoundPhase.Point);
        }

        [Test]
        public void Phase_FivePointRolled_IsPoint()
        {
            Round round = new Round();

            round.NextRoll(new Roll(1, 4));

            round.Phase.Should().Be(RoundPhase.Point);
        }

        [Test]
        public void Phase_SixPointRolled_IsPoint()
        {
            Round round = new Round();

            round.NextRoll(new Roll(3, 3));

            round.Phase.Should().Be(RoundPhase.Point);
        }

        [Test]
        public void Phase_EightPointRolled_IsPoint()
        {
            Round round = new Round();

            round.NextRoll(new Roll(3, 5));

            round.Phase.Should().Be(RoundPhase.Point);
        }

        [Test]
        public void Phase_NinePointRolled_IsPoint()
        {
            Round round = new Round();

            round.NextRoll(new Roll(4, 5));

            round.Phase.Should().Be(RoundPhase.Point);
        }

        [Test]
        public void Phase_TenPointRolled_IsPoint()
        {
            Round round = new Round();

            round.NextRoll(new Roll(6, 4));

            round.Phase.Should().Be(RoundPhase.Point);
        }
    }
}

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

            round.SetNextRoll(new Roll(3, 1));
            
            round.Phase.Should().Be(RoundPhase.Point);
        }

        [Test]
        public void Phase_FivePointRolled_IsPoint()
        {
            Round round = new Round();

            round.SetNextRoll(new Roll(1, 4));

            round.Phase.Should().Be(RoundPhase.Point);
        }

        [Test]
        public void Phase_SixPointRolled_IsPoint()
        {
            Round round = new Round();

            round.SetNextRoll(new Roll(3, 3));

            round.Phase.Should().Be(RoundPhase.Point);
        }

        [Test]
        public void Phase_EightPointRolled_IsPoint()
        {
            Round round = new Round();

            round.SetNextRoll(new Roll(3, 5));

            round.Phase.Should().Be(RoundPhase.Point);
        }

        [Test]
        public void Phase_NinePointRolled_IsPoint()
        {
            Round round = new Round();

            round.SetNextRoll(new Roll(4, 5));

            round.Phase.Should().Be(RoundPhase.Point);
        }

        [Test]
        public void Phase_TenPointRolled_IsPoint()
        {
            Round round = new Round();

            round.SetNextRoll(new Roll(6, 4));

            round.Phase.Should().Be(RoundPhase.Point);
        }

        [Test]
        public void SetNextRoll_PointEstablished_RaisesPointEstablishedEvent()
        {
            Round round = new Round();

            round.MonitorEvents();

            round.SetNextRoll(new Roll(6, 4));

            round.ShouldRaise("PointEstablished")
                .WithSender(round);
        }

        [Test]
        public void PointValue_ComeOutPhase_IsZero()
        {
            Round round = new Round();

            round.PointValue.Should().Be(0);
        }

        [Test]
        public void PointValue_PointEstablished_ReturnsCorrectValue()
        {
            Round round = new Round();
            
            round.SetNextRoll(new Roll(5, 5));

            round.PointValue.Should().Be(10);
        }

        [Test]
        public void SetNextRoll_TwoRolled_RaisesRoundEndedEvent()
        {
            Round round = new Round();

            round.MonitorEvents();

            round.SetNextRoll(new Roll(1, 1));

            round.ShouldRaise("RoundEnded")
                .WithSender(round)
                .WithArgs<RoundEndedEventArgs>(args => args.Result == RoundResult.Craps);
        }

        [Test]
        public void SetNextRoll_ThreeRolled_RaisesRoundEndedEvent()
        {
            Round round = new Round();

            round.MonitorEvents();

            round.SetNextRoll(new Roll(2, 1));

            round.ShouldRaise("RoundEnded")
                .WithSender(round)
                .WithArgs<RoundEndedEventArgs>(args => args.Result == RoundResult.Craps);
        }

        [Test]
        public void SetNextRoll_TwelveRolled_RaisesRoundEndedEvent()
        {
            Round round = new Round();

            round.MonitorEvents();

            round.SetNextRoll(new Roll(6, 6));

            round.ShouldRaise("RoundEnded")
                .WithSender(round)
                .WithArgs<RoundEndedEventArgs>(args => args.Result == RoundResult.Craps);
        }

        [Test]
        public void SetNextRoll_TwoRolledAfterPointEstablished_NoRoundEndedEventRaised()
        {
            Round round = new Round();

            round.MonitorEvents();

            round.SetNextRoll(new Roll(3, 5));
            round.SetNextRoll(new Roll(1, 1));

            round.ShouldNotRaise("RoundEnded");
        }

        [Test]
        public void SetNextRoll_SevenRolled_RaisesRoundEndedEvent()
        {
            Round round = new Round();

            round.MonitorEvents();

            round.SetNextRoll(new Roll(6, 1));

            round.ShouldRaise("RoundEnded")
                .WithSender(round)
                .WithArgs<RoundEndedEventArgs>(args => args.Result == RoundResult.Natural);
        }

        [Test]
        public void SetNextRoll_ElevenRolled_RaisesRoundEndedEvent()
        {
            Round round = new Round();

            round.MonitorEvents();

            round.SetNextRoll(new Roll(6, 5));

            round.ShouldRaise("RoundEnded")
                .WithSender(round)
                .WithArgs<RoundEndedEventArgs>(args => args.Result == RoundResult.Natural);
        }

        [Test]
        public void SetNextRoll_SevenPointEstablished_RaisesRoundEndedEvent()
        {
            Round round = new Round();

            round.MonitorEvents();

            round.SetNextRoll(new Roll(5, 1));

            round.SetNextRoll(new Roll(6, 1));

            round.ShouldRaise("RoundEnded")
                .WithSender(round)
                .WithArgs<RoundEndedEventArgs>(args => args.Result == RoundResult.SevenOut);
        }

        [Test]
        public void SetNextRoll_PointHitAfterPointEstablished_RaisesRoundEndedEvent()
        {
            Round round = new Round();

            round.MonitorEvents();

            round.SetNextRoll(new Roll(5, 1));

            round.SetNextRoll(new Roll(5, 1));

            round.ShouldRaise("RoundEnded")
                .WithSender(round)
                .WithArgs<RoundEndedEventArgs>(args => args.Result == RoundResult.PointHit);
        }

        [Test]
        public void Reset_RoundEnded_RoundIsReset()
        {
            Round round = new Round();

            round.SetNextRoll(new Roll(8, 1));
            round.SetNextRoll(new Roll(8, 1));

            round.Phase.Should().Be(RoundPhase.Point);
            round.PointValue.Should().Be(9);

            round.Reset();

            round.Phase.Should().Be(RoundPhase.ComeOut);
            round.PointValue.Should().Be(0);
        }
    }
}

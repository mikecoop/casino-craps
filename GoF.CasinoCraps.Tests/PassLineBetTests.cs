using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FluentAssertions;

namespace GoF.CasinoCraps.Tests
{
    public class PassLineBetTests
    {
        private PassLineBet bet;

        [SetUp]
        public void Setup()
        {
            bet = new PassLineBet(50);
        }

        [Test]
        public void Amount_WhenSet_ReturnsCorrectValue()
        {
            bet.Amount.Should().Be(50);
        }

        [Test]
        public void Status_WhenCreated_IsActive()
        {
            bet.Status.Should().Be(BetStatus.Active);
        }

        [Test]
        public void Status_NaturalRolledForRound_IsWon()
        {
            bet.RoundEnded(new RoundEndedEventArgs(RoundResult.Natural, new Roll(6, 1)));

            bet.Status.Should().Be(BetStatus.Won);
        }

        [Test]
        public void Status_CrapsRolledForRound_IsLost()
        {
            bet.RoundEnded(new RoundEndedEventArgs(RoundResult.Craps, new Roll(1, 1)));

            bet.Status.Should().Be(BetStatus.Lost);
        }

        [Test]
        public void Status_SevenOutRolledForRound_IsLost()
        {
            bet.RoundEnded(new RoundEndedEventArgs(RoundResult.SevenOut, new Roll(6, 1)));

            bet.Status.Should().Be(BetStatus.Lost);
        }

        [Test]
        public void Status_PointHitForRound_IsWon()
        {
            bet.RoundEnded(new RoundEndedEventArgs(RoundResult.PointHit, new Roll(6, 2)));

            bet.Status.Should().Be(BetStatus.Won);
        }

        [Test]
        public void PayoutAmount_BetWon_ReturnsCorrectAmount()
        {
            bet.RoundEnded(new RoundEndedEventArgs(RoundResult.PointHit, new Roll(6, 2)));

            bet.PayoutAmount.Should().Be(100);
        }

        [Test]
        public void PayoutAmount_BetLost_ReturnsCorrectAmount()
        {
            bet.RoundEnded(new RoundEndedEventArgs(RoundResult.SevenOut, new Roll(6, 1)));

            bet.PayoutAmount.Should().Be(0);
        }
    }
}

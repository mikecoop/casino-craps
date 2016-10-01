﻿using NUnit.Framework;
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
            game.RollDice(1, 6);

            game.RoundNumber.Should().Be(2);
        }

        [Test]
        public void RoundNumber_RoundEndedTwice_IsIncremented()
        {
            game.RollDice(1, 6);
            game.RollDice(1, 6);

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

        [Test]
        public void PlaceBet_GivenBet_BetIsPlaced()
        {
            game.PlaceBet(new PassLineBet(100));

            game.ActiveBets.Count().Should().Be(1);
        }

        [Test]
        public void CompletedBets_BetLost_BetIsAdded()
        {
            game.PlaceBet(new PassLineBet(100));

            game.RollDice(1, 6);

            game.CompletedBets.Count().Should().Be(1);
        }

        [Test]
        public void ActiveBets_BetLost_BetIsRemoved()
        {
            game.PlaceBet(new PassLineBet(100));

            game.RollDice(1, 6);

            game.ActiveBets.Count().Should().Be(0);
        }

        [Test]
        public void CompletedBets_BetPushed_BetIsAdded()
        {
            game.PlaceBet(new DontPassBet(200));

            game.RollDice(6, 6);

            game.CompletedBets.Count().Should().Be(1);
        }

        [Test]
        public void CompletedBets_NextRoll_BetIsRemoved()
        {
            game.PlaceBet(new PassLineBet(100));

            game.RollDice(1, 6);

            game.RollDice();

            game.CompletedBets.Count().Should().Be(0);
        }
    }
}

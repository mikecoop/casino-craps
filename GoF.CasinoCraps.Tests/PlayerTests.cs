using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using GoF.CasinoCraps;
using FluentAssertions;
using Moq;

namespace GoF.CasinoCraps.Tests
{
    public class PlayerTests
    {
        [Test]
        public void JoinGame_GivenGame_PlayerJoinsGame()
        {
            Player player = new Player(3000);

            Game game = new Game();

            player.JoinGame(game);

            player.Game.Should().Be(game);
        }

        [Test]
        public void PlaceBet_GivenAmount_AmountIsSubtractedFromMoney()
        {
            var mockGame = new Mock<IGame>();

            Player player = new Player(2000);
            player.JoinGame(mockGame.Object);

            player.PlaceBet(new BoxcarsBet(1000));
            
            player.Money.Should().Be(1000);
        }

        [Test]
        public void PlaceBet_GivenGame_BetIsAssociatedWithPlayer()
        {
            Player player = new Player(3000);

            Game game = new Game();

            player.JoinGame(game);

            player.PlaceBet(new BoxcarsBet(1000));

            game.ActiveBets.First().Player.Should().Be(player);
        }

        [Test]
        public void Money_BetWon_PayoutAmountIsAdded()
        {
            Player player = new Player(3000);

            Game game = new Game();

            player.JoinGame(game);

            player.PlaceBet(new PassLineBet(1000));

            player.RollDice(1, 6);

            game.CompletedBets.First().Status.Should().Be(BetStatus.Won);

            player.Money.Should().Be(4000);
        }

        [Test]
        public void PlaceBet_BetMoreThanHas_ThrowsException()
        {
            Player player = new Player(3000);

            Game game = new Game();

            player.JoinGame(game);

            Action act = () => player.PlaceBet(new PassLineBet(5000));

            act.ShouldThrow<BetAmountException>()
                .WithMessage("Insufficient funds for bet");
        }
    }
}

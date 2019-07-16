using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using Moq;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace BlackJack.Tests
{
    [TestClass]
    public class BlackJackTests
    {
        [TestMethod]
        public void DeckTest()
        {
            var card = new Card(1, CardType.Diamond);
            var mockDeck = new Mock<Deck>();
            mockDeck.Setup(deck => deck.GetCard()).Returns(card);
            Assert.That(mockDeck.Object.GetCard(), Is.EqualTo(card));
        }
        [TestMethod]
        public void GameTest()
        {
            var card = new Card(1, CardType.Diamond);
            var mockDeck = new Mock<Deck>();
            mockDeck.Setup(deck => deck.GetCard()).Returns(card);
            //var game = new Game(mockDeck.Object);
            //Assert.That(game.playerCards, Is.EqualTo(card));
        }
    }
}

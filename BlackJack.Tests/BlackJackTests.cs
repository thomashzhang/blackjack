using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
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
            var deck = new Deck();
            Assert.That(deck.GetCard(), Is.EqualTo(card));
        }
    }
}

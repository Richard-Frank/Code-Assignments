using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;
using RF.Cardgame.BL;
using RF.Cardgame.PL;

namespace RF.Cardgame.BL.Test
{
    [TestClass]
    public class utDeck
    {
        [TestMethod]
        public void LoadDecksTest()
        {
            CDeckList decks = new CDeckList();
            decks.Load();

            Assert.AreEqual(1, decks.Count);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            CDeck fetchDeck = new CDeck();
            fetchDeck.Id = new Guid("5D273D21-4688-4C64-95D5-C3D2F648F1BA");

            fetchDeck.LoadById();

            Assert.AreEqual(fetchDeck.Name, "Basic Deck");

        }

        [TestMethod]
        public void InsertTest()
        {
            CardGameDataContext oDc = new CardGameDataContext();

            CDeck deck = new CDeck();
            tblPlayer player = new tblPlayer();
            player = oDc.tblPlayers.Where(p => p.Name == "player").FirstOrDefault();

            deck.Name = "BL.Testdeck";

            deck.InsertPlayerDeck(player.Id);
           
            var fetchDeck = oDc.tblDecks.Where(p => p.Name == deck.Name).FirstOrDefault();

            Assert.IsNotNull(fetchDeck);
        }

        [TestMethod]
        public void UpdateTest()
        {
            CardGameDataContext oDc = new CardGameDataContext();
            var fetchDeck = oDc.tblDecks.Where(p => p.Name == "BL.Testdeck").FirstOrDefault();

            CDeck deck = new CDeck();
            deck.Id = fetchDeck.Id;

            deck.LoadById();

            deck.Name = "BL.TestdeckUpdate";

            deck.Update();

            fetchDeck = null;
            fetchDeck = oDc.tblDecks.Where(p => p.Name == "BL.TestdeckUpdate").FirstOrDefault();

            Assert.IsNotNull(fetchDeck);
        }

        [TestMethod]
        public void DeleteTest()
        {
            CardGameDataContext oDc = new CardGameDataContext();
            var fetchDeck = oDc.tblDecks.Where(p => p.Name == "BL.TestdeckUpdate").FirstOrDefault();

            CDeck deck = new CDeck();
            deck.Id = fetchDeck.Id;

            deck.Delete();

            var newfetch = oDc.tblDecks.Where(p => p.Name == "BL.TestdeckUpdate").FirstOrDefault();

            Assert.AreNotEqual(fetchDeck, newfetch);
            Assert.IsNull(newfetch);
        }

        [TestMethod]
        public void AssignCardsTest()
        {
            CCardList cards = new CCardList();
            cards.Load();

            CDeck deck = new CDeck();

            deck.Name = "AssignCardsTest";
            deck.Insert();

            CardGameDataContext oDc = new CardGameDataContext();
            var fetchDeck = oDc.tblDecks.Where(p => p.Name == "AssignCardsTest").FirstOrDefault();

            deck.Id = fetchDeck.Id;

            deck.AssignCards(cards);

            var DeckCardsFetch = oDc.tblDeckCards.Where(p => p.DeckId == deck.Id).FirstOrDefault();

            Assert.IsNotNull(DeckCardsFetch);
        }
    }
}

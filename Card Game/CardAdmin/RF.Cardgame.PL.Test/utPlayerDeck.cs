using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace RF.Cardgame.PL.Test
{
    [TestClass]
    public class utPlayerDeckDeck
    {
        [TestMethod]
        public void SelectTest()
        {
            CardGameDataContext oDc = new CardGameDataContext();

            List<tblPlayerDeck> playerDecklist = (from c in oDc.tblPlayerDecks select c).ToList();

            Assert.AreEqual(1, playerDecklist.Count);
        }

        [TestMethod]
        public void InsertTest()
        {
            CardGameDataContext oDc = new CardGameDataContext();

            List<tblPlayerDeck> OldplayerDecks = (from p in oDc.tblPlayerDecks select p).ToList();

            tblPlayerDeck newplayerDeck = new tblPlayerDeck();

            newplayerDeck.Id = new Guid("00000001-0000-1111-1111-000000000000");
            newplayerDeck.DeckId = oDc.tblDecks.Where(p => p.Name == "Basic Deck").FirstOrDefault().Id;
            newplayerDeck.PlayerId = oDc.tblPlayers.Where(p => p.Name == "player").FirstOrDefault().Id;

            oDc.tblPlayerDecks.InsertOnSubmit(newplayerDeck);

            oDc.SubmitChanges();

            Guid checkguid = newplayerDeck.Id;

            tblPlayerDeck playerDeckcard = (from p in oDc.tblPlayerDecks
                                            where p.Id == checkguid
                                            select p).FirstOrDefault();

            List<tblPlayerDeck> NewplayerDecks = (from p in oDc.tblPlayerDecks select p).ToList();

            Assert.IsNotNull(playerDeckcard);
            Assert.AreNotEqual(OldplayerDecks.Count, NewplayerDecks.Count);
        }

        [TestMethod]
        public void UpdateTest()
        {
            CardGameDataContext oDc = new CardGameDataContext();

            Guid pdId = new Guid("00000001-0000-1111-1111-000000000000");

            tblPlayerDeck playerDeck = (from p in oDc.tblPlayerDecks
                                where p.Id == pdId
                                select p).FirstOrDefault();
            Guid newdeckid = new Guid("11111111-1111-1111-1111-111111111111");

            playerDeck.DeckId = newdeckid;


            oDc.SubmitChanges();

            tblPlayerDeck updatedplayerDeck = (from p in oDc.tblPlayerDecks
                                       where p.DeckId == newdeckid
                                       select p).FirstOrDefault();


            Assert.IsNotNull(updatedplayerDeck);
        }

        [TestMethod]
        public void DeleteTest()
        {
            CardGameDataContext oDc = new CardGameDataContext();

            Guid deckid = new Guid("11111111-1111-1111-1111-111111111111");

            tblPlayerDeck playerDeck = (from p in oDc.tblPlayerDecks
                                where p.DeckId == deckid
                                select p).FirstOrDefault();

            oDc.tblPlayerDecks.DeleteOnSubmit(playerDeck);
            oDc.SubmitChanges();

            Assert.AreEqual(1, oDc.tblPlayerDecks.Count());
        }
    }
}

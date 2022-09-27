using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace RF.Cardgame.PL.Test
{
    [TestClass]
    public class utDeck
    {
        [TestMethod]
        public void SelectTest()
        {
            CardGameDataContext oDc = new CardGameDataContext();

            List<tblDeck> decklist = (from c in oDc.tblDecks select c).ToList();

            Assert.AreEqual(1, decklist.Count);
        }

        [TestMethod]
        public void InsertTest()
        {
            CardGameDataContext oDc = new CardGameDataContext();

            List<tblDeck> Olddecks = (from p in oDc.tblDecks select p).ToList();

            tblDeck newdeck = new tblDeck();

            newdeck.Id = Guid.NewGuid();
            newdeck.Name = "PL.Testdeck";

            oDc.tblDecks.InsertOnSubmit(newdeck);

            oDc.SubmitChanges();

            tblDeck deckcard = (from p in oDc.tblDecks
                                    where p.Name == "PL.Testdeck"
                                    select p).FirstOrDefault();

            List<tblDeck> Newdecks = (from p in oDc.tblDecks select p).ToList();

            Assert.IsNotNull(deckcard);
            Assert.AreNotEqual(Olddecks.Count, Newdecks.Count);
        }

        [TestMethod]
        public void UpdateTest()
        {
            CardGameDataContext oDc = new CardGameDataContext();

            tblDeck deck = (from p in oDc.tblDecks
                                where p.Name == "PL.Testdeck"
                                select p).FirstOrDefault();


            deck.Name = "PL.Testdeck Updated";


            oDc.SubmitChanges();

            tblDeck updateddeck = (from p in oDc.tblDecks
                                       where p.Name == "PL.Testdeck Updated"
                                       select p).FirstOrDefault();

            Assert.IsNotNull(updateddeck);
        }

        [TestMethod]
        public void DeleteTest()
        {
            CardGameDataContext oDc = new CardGameDataContext();

            tblDeck deck = (from p in oDc.tblDecks
                                where p.Name == "PL.Testdeck Updated"
                                select p).FirstOrDefault();

            oDc.tblDecks.DeleteOnSubmit(deck);
            oDc.SubmitChanges();

            Assert.AreEqual(1, oDc.tblDecks.Count());
        }
    }
}

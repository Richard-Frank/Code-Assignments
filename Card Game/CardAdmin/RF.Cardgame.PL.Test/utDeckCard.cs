using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace RF.Cardgame.PL.Test
{
    [TestClass]
    public class utDeckCard
    {
        [TestMethod]
        public void SelectTest()
        {
            CardGameDataContext oDc = new CardGameDataContext();

            List<tblDeckCard> deckCardlist = (from c in oDc.tblDeckCards select c).ToList();

            Assert.AreEqual(8, deckCardlist.Count);
        }

        [TestMethod]
        public void InsertTest()
        {
            CardGameDataContext oDc = new CardGameDataContext();

            List<tblDeckCard> OlddeckCards = (from p in oDc.tblDeckCards select p).ToList();

            tblDeckCard newdeckCard = new tblDeckCard();

            newdeckCard.Id = new Guid("00000001-0000-1111-1111-000000000000");
            newdeckCard.DeckId = oDc.tblDecks.Where(p => p.Name == "Basic Deck").FirstOrDefault().Id;
            newdeckCard.CardId= oDc.tblCards.Where(p => p.Name == "Billy").FirstOrDefault().Id;

            oDc.tblDeckCards.InsertOnSubmit(newdeckCard);

            oDc.SubmitChanges();

            Guid checkguid = newdeckCard.Id;

            tblDeckCard deckCardcard = (from p in oDc.tblDeckCards
                                            where p.Id == checkguid
                                            select p).FirstOrDefault();

            List<tblDeckCard> NewdeckCards = (from p in oDc.tblDeckCards select p).ToList();

            Assert.IsNotNull(deckCardcard);
            Assert.AreNotEqual(OlddeckCards.Count, NewdeckCards.Count);
        }

        [TestMethod]
        public void UpdateTest()
        {
            CardGameDataContext oDc = new CardGameDataContext();

            Guid dcId = new Guid("00000001-0000-1111-1111-000000000000");

            tblDeckCard deckCard = (from p in oDc.tblDeckCards
                                        where p.Id == dcId
                                        select p).FirstOrDefault();
            Guid newdeckid = new Guid("11111111-1111-1111-1111-111111111111");

            deckCard.DeckId = newdeckid;


            oDc.SubmitChanges();

            tblDeckCard updateddeckCard = (from p in oDc.tblDeckCards
                                               where p.DeckId == newdeckid
                                               select p).FirstOrDefault();


            Assert.IsNotNull(updateddeckCard);
        }

        [TestMethod]
        public void DeleteTest()
        {
            CardGameDataContext oDc = new CardGameDataContext();

            Guid deckid = new Guid("11111111-1111-1111-1111-111111111111");

            tblDeckCard deckCard = (from p in oDc.tblDeckCards
                                        where p.DeckId == deckid
                                        select p).FirstOrDefault();

            oDc.tblDeckCards.DeleteOnSubmit(deckCard);
            oDc.SubmitChanges();

            Assert.AreEqual(8, oDc.tblDeckCards.Count());
        }
    }
}

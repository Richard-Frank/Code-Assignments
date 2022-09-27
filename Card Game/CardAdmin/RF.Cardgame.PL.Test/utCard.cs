using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace RF.Cardgame.PL.Test
{
    [TestClass]
    public class utCard
    {
        [TestMethod]
        public void SelectTest()
        {
            CardGameDataContext oDc = new CardGameDataContext();

            List<tblCard> cardlist = (from c in oDc.tblCards select c).ToList();

            Assert.AreEqual(8, cardlist.Count);
        }

        [TestMethod]
        public void InsertTest()
        {
            CardGameDataContext oDc = new CardGameDataContext();

            List<tblCard> Oldcards = (from c in oDc.tblCards select c).ToList();

            tblCard newcard = new tblCard();

            newcard.Id = Guid.NewGuid();
            newcard.Name = "PL.Test Card, plz ignore.";
            newcard.Attack = 1337;
            newcard.Health = 58008;
            newcard.Cost = 15;

            oDc.tblCards.InsertOnSubmit(newcard);

            oDc.SubmitChanges();

            tblCard checkcard = (from c in oDc.tblCards
                                 where c.Name == "PL.Test Card, plz ignore."
                                 select c).FirstOrDefault();

            List<tblCard> Newcards = (from c in oDc.tblCards select c).ToList();

            Assert.IsNotNull(checkcard);
            Assert.AreNotEqual(Oldcards.Count, Newcards.Count);
        }

        [TestMethod]
        public void UpdateTest()
        {
            CardGameDataContext oDc = new CardGameDataContext();

            tblCard card = (from c in oDc.tblCards
                                 where c.Name == "PL.Test Card, plz ignore."
                                 select c).FirstOrDefault();

            card.Attack = 0;
            card.Health = 0;
            card.Cost = 0;
            card.Name = "UPDATED PL TEST";

            oDc.SubmitChanges();

            tblCard updatedcard = (from c in oDc.tblCards
                                   where c.Name == "UPDATED PL TEST"
                                   select c).FirstOrDefault();

            Assert.IsNotNull(updatedcard);
        }

        [TestMethod]
        public void DeleteTest()
        {
            CardGameDataContext oDc = new CardGameDataContext();

            tblCard card = (from c in oDc.tblCards
                            where c.Name == "UPDATED PL TEST"
                            select c).FirstOrDefault();

            oDc.tblCards.DeleteOnSubmit(card);
            oDc.SubmitChanges();

            Assert.AreEqual(8, oDc.tblCards.Count());
        }
    }
}
